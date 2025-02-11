using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerImageBuilder.Forms;
using DockerImageBuilder.Properties;
using Newtonsoft.Json;

namespace DockerImageBuilder.Panels
{
    public partial class ProjectsListPanel : UserControl
    {
        public event Action<string> OnPathChanged = delegate { };
        public event Action<string, Color> OnLogRequest = delegate { };
        public event Action OnLogNewLineRequest = delegate { };

        private bool loadImageToMinikube = true;

        public ProjectsListPanel()
        {
            InitializeComponent();

            /*grid.DataBindingComplete += (s, e) =>
            {
                grid.ClearSelection();
                grid.CurrentCell = null;
            };*/

            grid.CurrentCellDirtyStateChanged += (sender, e) =>
            {
                if (grid.IsCurrentCellDirty)
                {
                    grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
        }

        private void ProjectsListPanel_Load(object sender, EventArgs e)
        {
            // propagate log events
            BuildService.OnLogRequest += (msg, color) => OnLogRequest(msg, color);
        }

        public void LoadData(string path)
        {
            grid.AutoGenerateColumns = false;
            var data = Service.ImportDirectory(path);
            grid.DataSource = data;
        }

        private void btImport_Click(object sender, EventArgs e) // import projects
        {
            if (grid.Rows.Count == 0 || MessageBox.Show(@"Are you sure you want to clear the projects list and import it from the selected directory?", @"Import projects",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
                return;

            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            grid.DataSource = null;
            OnPathChanged(dialog.SelectedPath);
            LoadData(dialog.SelectedPath);
        }

        private async void btBuild_Click(object sender, EventArgs e)
        {
            ProcessForm form = new ProcessForm();
            if (form.ShowDialog(this) != DialogResult.OK) return;

            var selectedRows = GetCheckedRows(grid);
            if (selectedRows.Count == 0)
            {
                MessageBox.Show(@"Please select a project to build");
                return;
            }

            foreach (DataGridViewRow row in selectedRows)
            {
                var project = (ProjectDirectoryInfo)row.DataBoundItem;

                // build project
                if (project.Vcs != VcType.None)
                {
                    OnLogRequest($"Start building project {project.Caption}\n", Color.RoyalBlue);
                    await BuildService.BuildProject(project.Path);
                    OnLogNewLineRequest();
                }

                // build docker image
                if (project.IsDocker)
                {
                    OnLogRequest($"Start building docker image {project.ImageName}\n", Color.RoyalBlue);
                    await BuildService.BuildDockerImage(project.Path, project.ImageName, project.ImageTag);
                    OnLogNewLineRequest();
                }

                // load image to minikube
                if (loadImageToMinikube)
                {
                    OnLogRequest($"Loading image {project.ImageName} to minikube\n", Color.RoyalBlue);
                    await BuildService.LoadImageToMinikube(project.Path, project.ImageName, project.ImageTag);
                    OnLogNewLineRequest();
                }
            }

            OnLogRequest("Done!", Color.RoyalBlue);
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // status column
            if (grid.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value is Statuses status)
                {
                    switch (status)
                    {
                        case Statuses.Failed:
                            e.CellStyle.ForeColor = Color.IndianRed;
                            break;
                        case Statuses.Done:
                            e.CellStyle.ForeColor = Color.Green;
                            break;
                        case Statuses.Processing:
                            e.CellStyle.ForeColor = Color.Orange;
                            break;
                        default:
                            e.CellStyle.ForeColor = grid.DefaultCellStyle.ForeColor;
                            break;
                    }
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = @"*.json|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var data = grid.DataSource as List<ProjectDirectoryInfo>;
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(dialog.FileName, json);
            }
        }

        private static List<DataGridViewRow> GetCheckedRows(DataGridView dataGridView)
        {
            var checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.DataBoundItem is ProjectDirectoryInfo item && item.Checked)
                {
                    checkedRows.Add(row);
                }
            }

            return checkedRows;
        }

        private void btAdd_Click(object sender, EventArgs e) // add project
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            var project = Service.CreateProjectDirectory(dialog.SelectedPath);
            if (project == null)
            {
                MessageBox.Show(@"No VCS project found");
                return;
            }

            var data = grid.DataSource as List<ProjectDirectoryInfo>;
            grid.DataSource = null;
            if (data == null) data = new List<ProjectDirectoryInfo>();
            data.Add(project);
            grid.DataSource = data;
        }

        private void btOpen_Click(object sender, EventArgs e) // open configuration
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"*.json|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var json = File.ReadAllText(dialog.FileName);
                var data = JsonConvert.DeserializeObject<List<ProjectDirectoryInfo>>(json);
                grid.DataSource = data;
            }
        }

        private void btClear_Click(object sender, EventArgs e) // clear list
        {
            if (grid.Rows.Count > 0 &&
                MessageBox.Show(@"Are you sure you want to clear the project list?", @"Clear list", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                grid.DataSource = null;
            }
        }

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                // Получаем привязанный объект
                if (grid.Rows[e.RowIndex].DataBoundItem is ProjectDirectoryInfo dataItem)
                {
                    // Получаем иконки из объекта
                    Image vcsIcon = dataItem.VcsIcon;
                    Image dockerIcon = dataItem.DockerIcon;

                    // Отображаем иконки
                    if (vcsIcon != null)
                    {
                        e.Graphics.DrawImage(vcsIcon, new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, 16, 16));
                    }

                    if (dockerIcon != null)
                    {
                        e.Graphics.DrawImage(dockerIcon, new Rectangle(e.CellBounds.X + 20, e.CellBounds.Y + 2, 16, 16));
                    }
                }

                e.Handled = true;
            }
        }
    }
}