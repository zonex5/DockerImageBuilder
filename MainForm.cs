using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerImageBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadData(dialog.SelectedPath);
            }
        }

        private void LoadData(string path)
        {
            //grid.AutoGenerateColumns = false;
            //grid.DataSource = GetSubdirectories(path);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(@"C:\Users\zonex\Desktop\gke-tracing");
        }

        private void btBuild_Click(object sender, EventArgs e)
        {
            var selectedRows = GetCheckedRows(grid);
            if (selectedRows.Count == 0)
            {
                MessageBox.Show(@"Please select a project to build");
                return;
            }

            foreach (DataGridViewRow row in selectedRows)
            {
                //AppendTextToRichTextBox($"Start building project {row.Cells[1].Value}\n", Color.DodgerBlue);
                //var project = (ProjectDirectoryInfo)row.DataBoundItem;
                //switch (ProjectVcs(project.Path))
                //{
                //    case VcType.Gradle:
                //        await RunProcessAsync("/c gradlew clean build -x testClasses", project.Path);
                //        break;
                //    case VcType.Maven:
                //        await RunProcessAsync("/c mvn clean install -Dmaven.test.skip=true", project.Path);
                //        break;
                //    default:
                //        AppendTextToRichTextBox($"! No VCS project found", Color.Chocolate);
                //        break;
                //}
                //
                //AppendTextToRichTextBox("\n", Color.Black);
            }
        }

        static List<DataGridViewRow> GetCheckedRows(DataGridView dataGridView)
        {
            var checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0] is DataGridViewCheckBoxCell checkBoxCell && checkBoxCell.Value is bool isChecked && isChecked)
                {
                    checkedRows.Add(row);
                }
            }

            return checkedRows;
        }
    }
}