using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DockerImageBuilder.Panels
{
    public partial class ProjectsListPanel : UserControl
    {
        public event Action<string> OnPathChanged = delegate { };
        public event Action<string, Color> OnLogRequest = delegate { };

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
            var selectedRows = GetCheckedRows(grid);
            if (selectedRows.Count == 0)
            {
                MessageBox.Show(@"Please select a project to build");
                return;
            }

            foreach (DataGridViewRow row in selectedRows)
            {
                var project = (ProjectDirectoryInfo)row.DataBoundItem;
                OnLogRequest($"Start building project {project.Caption}\n", Color.RoyalBlue);
                switch (Service.ProjectVcs(project.Path))
                {
                    case VcType.Gradle:
                        await Service.RunProcessAsync(@"/c gradlew clean build -x testClasses", project.Path);
                        break;
                    case VcType.Maven:
                        await Service.RunProcessAsync(@"/c mvn clean install -Dmaven.test.skip=true", project.Path);
                        break;
                    case VcType.None:
                    default:
                        OnLogRequest($"! No VCS project found", Color.Chocolate);
                        break;
                }

                OnLogRequest("\n", Color.Black);
            }

            OnLogRequest("Done!", Color.RoyalBlue);
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
    }
}