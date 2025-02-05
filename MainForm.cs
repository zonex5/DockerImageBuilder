using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DockerImageBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<ProjectDirectoryInfo> GetSubdirectories(string path)
        {
            List<ProjectDirectoryInfo> subdirectories = new List<ProjectDirectoryInfo>();
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                string dirName = Path.GetFileName(dir);
                if (!dirName.StartsWith("."))
                {
                    subdirectories.Add(new ProjectDirectoryInfo { Caption = Path.GetFileName(dir), Path = dir });
                }
            }
            return subdirectories;
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadData(dialog.SelectedPath);
            }
        }

        private void LoadData(string path)
        {
            list.DataSource = GetSubdirectories(path);
            list.DisplayMember = "Caption";
            list.ValueMember = "Path";

            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetItemChecked(i, true);
            }

            ///
            grid.AutoGenerateColumns = false;
            grid.DataSource = GetSubdirectories(path);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(@"C:\Users\zonex\Desktop\DockerImageBuilder");
        }
    }
}