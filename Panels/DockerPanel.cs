using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerImageBuilder.Services;

namespace DockerImageBuilder.Panels
{
    public partial class DockerPanel : UserControl
    {
        public event Action<string> OnContextChanged = delegate { };
        public event Action<string> OnError = delegate { };

        private bool formIsLoading = true;

        public DockerPanel()
        {
            InitializeComponent();
        }

        private void DockerPanel_Load(object sender, EventArgs e)
        {
            try
            {
                cbContext.Items.AddRange(Service.GetAllContexts().ToArray());
                cbContext.SelectedItem = Service.GetCurrentContext();
                CheckMinikube();
            }
            catch (Exception ex)
            {
                OnError(ex.Message);
            }

            // set checkbox values from registry
            chLoad.Checked = Registry.GetValueFromRegistry("LoadImage") == "True";
            chDelete.Checked = Registry.GetValueFromRegistry("DeleteImage") == "True";
            tbHub.Text = Registry.GetValueFromRegistry("Repository");

            formIsLoading = false;
        }

        private void CheckMinikube()
        {
            var isMinikube = Service.GetCurrentContext() == "minikube";
            panel1.Enabled = isMinikube;
            //panel2.Visible = !isMinikube;
        }

        private void cbContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formIsLoading) return;
            var newContext = cbContext.SelectedItem.ToString();
            try
            {
                Service.SetCurrentContext(newContext);
            }
            catch (Exception ex)
            {
                OnError(ex.Message);
            }

            CheckMinikube();
            OnContextChanged(newContext);
        }

        private void checkbox_Check(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                var key = checkBox == chLoad ? "LoadImage" :
                    checkBox == chDelete ? "DeleteImage" :
                    null;
                if (key != null)
                {
                    Registry.PutValueToRegistry(key, checkBox.Checked.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // set minikube context
        {
            try
            {
                Service.SetCurrentContext("minikube");
                CheckMinikube();
            }
            catch (Exception ex)
            {
                OnError(ex.Message);
            }

            OnContextChanged("minikube");
        }

        private void tbHub_Leave(object sender, EventArgs e)
        {
            Registry.PutValueToRegistry("Repository", tbHub.Text);
        }

        private void tbHub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Registry.PutValueToRegistry("Repository", tbHub.Text);
                e.Handled = true;
            }
        }
    }
}