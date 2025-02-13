namespace DockerImageBuilder.Panels
{
    partial class ProjectsListPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsListPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btClear = new System.Windows.Forms.ToolStripButton();
            this.btImport = new System.Windows.Forms.ToolStripButton();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btOpen = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btBuild = new System.Windows.Forms.ToolStripButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.Cheched = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icons = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildDockerImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClear,
            this.btImport,
            this.btAdd,
            this.btOpen,
            this.btSave,
            this.btDelete,
            this.toolStripSeparator1,
            this.btBuild});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(439, 28);
            this.toolStrip1.TabIndex = 3;
            // 
            // btClear
            // 
            this.btClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(23, 25);
            this.btClear.Text = "Clear configuration";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btImport
            // 
            this.btImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btImport.Image = ((System.Drawing.Image)(resources.GetObject("btImport.Image")));
            this.btImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(23, 25);
            this.btImport.Text = "Import projects";
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 25);
            this.btAdd.Text = "Add project";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btOpen
            // 
            this.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpen.Image = ((System.Drawing.Image)(resources.GetObject("btOpen.Image")));
            this.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(23, 25);
            this.btOpen.Text = "Open configuration";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 25);
            this.btSave.Text = "Save Configuration";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(23, 25);
            this.btDelete.Text = "Remove project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btBuild
            // 
            this.btBuild.Image = ((System.Drawing.Image)(resources.GetObject("btBuild.Image")));
            this.btBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBuild.Name = "btBuild";
            this.btBuild.Size = new System.Drawing.Size(54, 25);
            this.btBuild.Text = "Build";
            this.btBuild.Click += new System.EventHandler(this.btBuild_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "gradle.png");
            this.imageList.Images.SetKeyName(1, "maven.png");
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cheched,
            this.Project,
            this.Icons,
            this.ImageName,
            this.ImageTag,
            this.Status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 52);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 26;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(439, 392);
            this.grid.TabIndex = 5;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            this.grid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grid_CellPainting);
            // 
            // Cheched
            // 
            this.Cheched.DataPropertyName = "Checked";
            this.Cheched.HeaderText = "";
            this.Cheched.Name = "Cheched";
            this.Cheched.Width = 20;
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
            // Icons
            // 
            this.Icons.HeaderText = "";
            this.Icons.Name = "Icons";
            this.Icons.Width = 50;
            // 
            // ImageName
            // 
            this.ImageName.DataPropertyName = "ImageName";
            this.ImageName.HeaderText = "Image Name";
            this.ImageName.Name = "ImageName";
            this.ImageName.ReadOnly = true;
            this.ImageName.Width = 250;
            // 
            // ImageTag
            // 
            this.ImageTag.DataPropertyName = "ImageTag";
            this.ImageTag.HeaderText = "Image Tag";
            this.ImageTag.Name = "ImageTag";
            this.ImageTag.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurationToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.clearConfigurationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importProjectsToolStripMenuItem,
            this.addProjectToConfigurationToolStripMenuItem,
            this.removeProjectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigurationToolStripMenuItem
            // 
            this.openConfigurationToolStripMenuItem.Name = "openConfigurationToolStripMenuItem";
            this.openConfigurationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openConfigurationToolStripMenuItem.Text = "Open configuration";
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            // 
            // clearConfigurationToolStripMenuItem
            // 
            this.clearConfigurationToolStripMenuItem.Name = "clearConfigurationToolStripMenuItem";
            this.clearConfigurationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.clearConfigurationToolStripMenuItem.Text = "Clear configuration";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // importProjectsToolStripMenuItem
            // 
            this.importProjectsToolStripMenuItem.Name = "importProjectsToolStripMenuItem";
            this.importProjectsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.importProjectsToolStripMenuItem.Text = "Import projects";
            // 
            // addProjectToConfigurationToolStripMenuItem
            // 
            this.addProjectToConfigurationToolStripMenuItem.Name = "addProjectToConfigurationToolStripMenuItem";
            this.addProjectToConfigurationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addProjectToConfigurationToolStripMenuItem.Text = "Add project";
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.removeProjectToolStripMenuItem.Text = "Remove project";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBuildToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // startBuildToolStripMenuItem
            // 
            this.startBuildToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startBuildToolStripMenuItem.Image")));
            this.startBuildToolStripMenuItem.Name = "startBuildToolStripMenuItem";
            this.startBuildToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.startBuildToolStripMenuItem.Text = "Start build";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildProjectMenuItem,
            this.buildDockerImageMenuItem,
            this.loadImageMenuItem,
            this.pushImageMenuItem,
            this.deleteImageMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // buildProjectMenuItem
            // 
            this.buildProjectMenuItem.CheckOnClick = true;
            this.buildProjectMenuItem.Name = "buildProjectMenuItem";
            this.buildProjectMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buildProjectMenuItem.Text = "Build project";
            this.buildProjectMenuItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // buildDockerImageMenuItem
            // 
            this.buildDockerImageMenuItem.CheckOnClick = true;
            this.buildDockerImageMenuItem.Name = "buildDockerImageMenuItem";
            this.buildDockerImageMenuItem.Size = new System.Drawing.Size(203, 22);
            this.buildDockerImageMenuItem.Text = "Build docker image";
            this.buildDockerImageMenuItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // loadImageMenuItem
            // 
            this.loadImageMenuItem.CheckOnClick = true;
            this.loadImageMenuItem.Name = "loadImageMenuItem";
            this.loadImageMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadImageMenuItem.Text = "Load image to minikube";
            this.loadImageMenuItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // deleteImageMenuItem
            // 
            this.deleteImageMenuItem.CheckOnClick = true;
            this.deleteImageMenuItem.Name = "deleteImageMenuItem";
            this.deleteImageMenuItem.Size = new System.Drawing.Size(203, 22);
            this.deleteImageMenuItem.Text = "Delete docker image";
            this.deleteImageMenuItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pushImageMenuItem
            // 
            this.pushImageMenuItem.Name = "pushImageMenuItem";
            this.pushImageMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pushImageMenuItem.Text = "Push docker image";
            this.pushImageMenuItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // ProjectsListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProjectsListPanel";
            this.Size = new System.Drawing.Size(439, 444);
            this.Load += new System.EventHandler(this.ProjectsListPanel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem buildDockerImageMenuItem;

        private System.Windows.Forms.DataGridViewImageColumn Icons;

        private System.Windows.Forms.DataGridViewCheckBoxColumn Cheched;

        private System.Windows.Forms.ToolStripButton btClear;

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btImport;
        private System.Windows.Forms.ToolStripButton btBuild;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btOpen;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pushImageMenuItem;
    }
}
