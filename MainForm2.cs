using System;
using System.Drawing;
using System.Windows.Forms;
using DockerImageBuilder.Panels;
using WeifenLuo.WinFormsUI.Docking;

namespace DockerImageBuilder
{
    public partial class MainForm2 : Form
    {
        string path = @"C:\Users\zonex\Desktop\gke-tracing";

        private ProjectsListPanel ProjectsPanel;
        private RichTextBox logger;

        public MainForm2()
        {
            InitializeComponent();

            ProjectsPanel = new ProjectsListPanel();
            ProjectsPanel.Dock = DockStyle.Fill;
            ProjectsPanel.LoadData(path);
            ProjectsPanel.OnPathChanged += newPath =>
            {
                path = newPath;
                lbPath.Text = path;
            };
            ProjectsPanel.OnLogRequest += (msg, color) => AppendTextToLogger(logger, msg, color);
            ProjectsPanel.OnLogNewLineRequest += () => AppendTextToLogger(logger, "\n", Color.Transparent);
            Service.OnLogRequest += (msg, color) => AppendTextToLogger(logger, msg, color);
            AddProjectsListPanel();
            AddLogsPanel();
            //AddDockerPanel();

            lbPath.Text = path;
        }

        private void AddProjectsListPanel()
        {
            DockContent dock = new DockContent();
            dock.Text = @"Projects Inspector";
            dock.CloseButtonVisible = false;
            dock.CloseButton = false;
            dock.AutoScaleMode = AutoScaleMode.Dpi;
            dock.Controls.Add(ProjectsPanel);
            dock.Show(dockPanel, DockState.Document);
        }

        private void AddLogsPanel()
        {
            DockContent dock = new DockContent();
            dock.AutoScaleMode = AutoScaleMode.Dpi;
            dock.Text = @"Build Output";
            dock.CloseButtonVisible = false;
            dock.ShowIcon = false;
            dock.Controls.Add(CreateLogger());
            dock.Show(dockPanel, DockState.DockBottom);
        }

        private void AddDockerPanel()
        {
            DockContent dock = new DockContent();
            dock.AutoScaleMode = AutoScaleMode.Dpi;
            dock.Text = @"Kubernetes";
            dock.CloseButtonVisible = false;
            dock.ShowIcon = false;
            dock.Show(dockPanel, DockState.DockRight);

            var cb = new DockerPanel();
            cb.Dock = DockStyle.Fill;
            cb.OnError += (msg) => AppendTextToLogger(logger, msg, Color.IndianRed);
            cb.OnContextChanged += (msg) => AppendTextToLogger(logger, $"Context changed to {msg}", Color.RoyalBlue);

            dock.Controls.Add(cb);
        }

        private RichTextBox CreateLogger()
        {
            logger = new RichTextBox();
            logger.Dock = DockStyle.Fill;
            return logger;
        }

        private static void AppendTextToLogger(RichTextBox logs, string text, Color color)
        {
            if (text == null) return;

            if (text.Contains("BUILD SUCCESS"))
                color = Color.Green;

            if (logs.InvokeRequired)
            {
                logs.Invoke(new Action(() => AppendTextToLogger(logs, text, color)));
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