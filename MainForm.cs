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

        private static List<ProjectDirectoryInfo> GetSubdirectories(string path)
        {
            var subdirectories = new List<ProjectDirectoryInfo>();
            var directories = Directory.GetDirectories(path);
            foreach (var dir in directories)
            {
                var dirName = Path.GetFileName(dir);
                if (!dirName.StartsWith(".") && ProjectVcs(dir) != VcType.None)
                {
                    subdirectories.Add(new ProjectDirectoryInfo { Caption = dirName, Path = dir });
                }
            }

            return subdirectories;
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
            grid.AutoGenerateColumns = false;
            grid.DataSource = GetSubdirectories(path);
        }

        private static VcType ProjectVcs(string path)
        {
            if (File.Exists(Path.Combine(path, "build.gradle")) || File.Exists(Path.Combine(path, "build.gradle.kts")))
                return VcType.Gradle;
            if (File.Exists(Path.Combine(path, "pom.xml")))
                return VcType.Maven;
            return VcType.None;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(@"C:\Users\zonex\Desktop\gke-tracing");
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
                AppendTextToRichTextBox($"Start building project {row.Cells[1].Value}\n", Color.DodgerBlue);
                var project = (ProjectDirectoryInfo)row.DataBoundItem;
                switch (ProjectVcs(project.Path))
                {
                    case VcType.Gradle:
                        await RunProcessAsync("/c gradlew clean build -x testClasses", project.Path);
                        break;
                    case VcType.Maven:
                        await RunProcessAsync("/c mvn clean install -Dmaven.test.skip=true", project.Path);
                        break;
                    default:
                        AppendTextToRichTextBox($"! No VCS project found", Color.Chocolate);
                        break;
                }

                AppendTextToRichTextBox("\n", Color.Black);
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

        private Task RunProcessAsync(string command, string path)
        {
            return Task.Run(() =>
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8,
                    WorkingDirectory = path
                };

                using (Process process = new Process { StartInfo = psi })
                {
                    process.OutputDataReceived += (sender, e) => AppendTextToRichTextBox(e.Data, Color.Black);
                    process.ErrorDataReceived += (sender, e) => AppendTextToRichTextBox(e.Data, Color.OrangeRed);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();
                }
            });
        }

        private void AppendTextToRichTextBox(string text, Color color)
        {
            if (text == null) return;

            if (text.Contains("BUILD SUCCESSFUL"))
                color = Color.Green;

            if (logs.InvokeRequired)
            {
                logs.Invoke(new Action<string, Color>(AppendTextToRichTextBox), text, color);
            }
            else
            {
                logs.SelectionStart = logs.TextLength;
                logs.SelectionLength = 0;
                logs.SelectionColor = color;

                logs.AppendText(text + Environment.NewLine);
                logs.ScrollToCaret();

                logs.SelectionColor = logs.ForeColor;
            }
        }
    }
}