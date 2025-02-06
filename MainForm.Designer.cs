namespace DockerImageBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btImport = new System.Windows.Forms.ToolStripButton();
            this.btBuild = new System.Windows.Forms.ToolStripButton();
            this.chLoad = new System.Windows.Forms.CheckBox();
            this.chDelete = new System.Windows.Forms.CheckBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.btImport, this.btBuild });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btImport
            // 
            this.btImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btImport.Image = ((System.Drawing.Image)(resources.GetObject("btImport.Image")));
            this.btImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(23, 22);
            this.btImport.Text = "Import";
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btBuild
            // 
            this.btBuild.Image = ((System.Drawing.Image)(resources.GetObject("btBuild.Image")));
            this.btBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBuild.Name = "btBuild";
            this.btBuild.Size = new System.Drawing.Size(54, 22);
            this.btBuild.Text = "Build";
            this.btBuild.Click += new System.EventHandler(this.btBuild_Click);
            // 
            // chLoad
            // 
            this.chLoad.AutoSize = true;
            this.chLoad.Checked = true;
            this.chLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLoad.Location = new System.Drawing.Point(191, 291);
            this.chLoad.Margin = new System.Windows.Forms.Padding(2);
            this.chLoad.Name = "chLoad";
            this.chLoad.Size = new System.Drawing.Size(139, 17);
            this.chLoad.TabIndex = 2;
            this.chLoad.Text = "Load image to Minikube";
            this.chLoad.UseVisualStyleBackColor = true;
            // 
            // chDelete
            // 
            this.chDelete.AutoSize = true;
            this.chDelete.Checked = true;
            this.chDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chDelete.Location = new System.Drawing.Point(12, 292);
            this.chDelete.Name = "chDelete";
            this.chDelete.Size = new System.Drawing.Size(174, 17);
            this.chDelete.TabIndex = 3;
            this.chDelete.Text = "Delete image from local Docker";
            this.chDelete.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Check, this.Project, this.Status });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(8, 28);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(486, 258);
            this.grid.TabIndex = 4;
            // 
            // Check
            // 
            this.Check.DataPropertyName = "Checked";
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Check.Width = 30;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project.DataPropertyName = "Caption";
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            this.Project.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Project.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // logs
            // 
            this.logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logs.Location = new System.Drawing.Point(8, 315);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(486, 195);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 522);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.chDelete);
            this.Controls.Add(this.chLoad);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docker Image Builder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btImport;
        private System.Windows.Forms.CheckBox chLoad;
        private System.Windows.Forms.CheckBox chDelete;
        private System.Windows.Forms.ToolStripButton btBuild;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.RichTextBox logs;
    }
}