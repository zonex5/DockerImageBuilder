using System.ComponentModel;

namespace DockerImageBuilder.Forms
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chDelete = new System.Windows.Forms.CheckBox();
            this.chLoad = new System.Windows.Forms.CheckBox();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.lbMinikube = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(84, 95);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(115, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Process";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To continue set context to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chDelete);
            this.panel1.Controls.Add(this.chLoad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 52);
            this.panel1.TabIndex = 12;
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
            // 
            // panelWarning
            // 
            this.panelWarning.Controls.Add(this.lbMinikube);
            this.panelWarning.Controls.Add(this.label1);
            this.panelWarning.Location = new System.Drawing.Point(46, 60);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(180, 19);
            this.panelWarning.TabIndex = 13;
            // 
            // lbMinikube
            // 
            this.lbMinikube.AutoSize = true;
            this.lbMinikube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMinikube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMinikube.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbMinikube.Location = new System.Drawing.Point(130, 5);
            this.lbMinikube.Name = "lbMinikube";
            this.lbMinikube.Size = new System.Drawing.Size(50, 13);
            this.lbMinikube.TabIndex = 14;
            this.lbMinikube.Text = "Minikube";
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 126);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label lbMinikube;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chDelete;
        private System.Windows.Forms.CheckBox chLoad;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btOk;

        #endregion
    }
}