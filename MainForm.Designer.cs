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
            this.list = new System.Windows.Forms.CheckedListBox();
            this.chLoad = new System.Windows.Forms.CheckBox();
            this.chDelete = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btImport,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(564, 25);
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
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.CheckOnClick = true;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(7, 28);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(330, 72);
            this.list.TabIndex = 1;
            // 
            // chLoad
            // 
            this.chLoad.AutoSize = true;
            this.chLoad.Checked = true;
            this.chLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLoad.Location = new System.Drawing.Point(345, 28);
            this.chLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.chDelete.Location = new System.Drawing.Point(345, 50);
            this.chDelete.Name = "chDelete";
            this.chDelete.Size = new System.Drawing.Size(174, 17);
            this.chDelete.TabIndex = 3;
            this.chDelete.Text = "Delete image from local Docker";
            this.chDelete.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton1.Text = "Build";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Project,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(7, 126);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
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
            this.grid.Size = new System.Drawing.Size(477, 150);
            this.grid.TabIndex = 4;
            // 
            // Check
            // 
            this.Check.DataPropertyName = "Checked";
            this.Check.Frozen = true;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 392);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.chDelete);
            this.Controls.Add(this.chLoad);
            this.Controls.Add(this.list);
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
        private System.Windows.Forms.CheckedListBox list;
        private System.Windows.Forms.CheckBox chLoad;
        private System.Windows.Forms.CheckBox chDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}