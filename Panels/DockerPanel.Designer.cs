namespace DockerImageBuilder.Panels
{
    partial class DockerPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chDelete = new System.Windows.Forms.CheckBox();
            this.chLoad = new System.Windows.Forms.CheckBox();
            this.cbContext = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHub = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chDelete
            // 
            this.chDelete.AutoSize = true;
            this.chDelete.Checked = true;
            this.chDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chDelete.Location = new System.Drawing.Point(4, 28);
            this.chDelete.Name = "chDelete";
            this.chDelete.Size = new System.Drawing.Size(174, 17);
            this.chDelete.TabIndex = 5;
            this.chDelete.Text = "Delete image from local Docker";
            this.chDelete.UseVisualStyleBackColor = true;
            this.chDelete.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // chLoad
            // 
            this.chLoad.AutoSize = true;
            this.chLoad.Checked = true;
            this.chLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLoad.Location = new System.Drawing.Point(4, 6);
            this.chLoad.Margin = new System.Windows.Forms.Padding(2);
            this.chLoad.Name = "chLoad";
            this.chLoad.Size = new System.Drawing.Size(139, 17);
            this.chLoad.TabIndex = 4;
            this.chLoad.Text = "Load image to Minikube";
            this.chLoad.UseVisualStyleBackColor = true;
            this.chLoad.CheckedChanged += new System.EventHandler(this.checkbox_Check);
            // 
            // cbContext
            // 
            this.cbContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContext.FormattingEnabled = true;
            this.cbContext.Location = new System.Drawing.Point(3, 27);
            this.cbContext.Name = "cbContext";
            this.cbContext.Size = new System.Drawing.Size(256, 21);
            this.cbContext.TabIndex = 8;
            this.cbContext.SelectedIndexChanged += new System.EventHandler(this.cbContext_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chDelete);
            this.panel1.Controls.Add(this.chLoad);
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 61);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 100);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(58, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set context to \'minikube\'";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "These options are available only for the Minikube cluster.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current context:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Docker Hub repository:";
            // 
            // tbHub
            // 
            this.tbHub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHub.Location = new System.Drawing.Point(7, 147);
            this.tbHub.MaxLength = 50;
            this.tbHub.Name = "tbHub";
            this.tbHub.Size = new System.Drawing.Size(252, 20);
            this.tbHub.TabIndex = 13;
            this.tbHub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHub_KeyPress);
            this.tbHub.Leave += new System.EventHandler(this.tbHub_Leave);
            // 
            // DockerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbHub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbContext);
            this.Name = "DockerPanel";
            this.Size = new System.Drawing.Size(263, 383);
            this.Load += new System.EventHandler(this.DockerPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbHub;

        private System.Windows.Forms.Label label3;

        #endregion

        private System.Windows.Forms.CheckBox chDelete;
        private System.Windows.Forms.CheckBox chLoad;
        private System.Windows.Forms.ComboBox cbContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
