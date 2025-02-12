using System;
using System.Windows.Forms;
using DockerImageBuilder.Services;

namespace DockerImageBuilder.Forms
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            var isMinikube = Service.GetCurrentContext() == "minikube";
            panelWarning.Visible = !isMinikube;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}