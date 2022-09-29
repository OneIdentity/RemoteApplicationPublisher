using System.Windows.Forms;

namespace RemoteApplicationPublisher
{
    public partial class RemoteAppMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAppMainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.SmallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.NoAppsLabel = new System.Windows.Forms.Label();
            this.ToolsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRemoteAppadvancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HostOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BackupAllRemoteAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.remoteAppCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolsMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteAppCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SmallIcons
            // 
            this.SmallIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.SmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcons.ImageStream")));
            this.SmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcons.Images.SetKeyName(0, "smallicons.ico");
            // 
            // SmallerIcons
            // 
            this.SmallerIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.SmallerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallerIcons.ImageStream")));
            this.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallerIcons.Images.SetKeyName(0, "tools_16x16.png");
            this.SmallerIcons.Images.SetKeyName(1, "help_16x16.png");
            this.SmallerIcons.Images.SetKeyName(2, "folder_16x16.png");
            this.SmallerIcons.Images.SetKeyName(3, "msi small.ico");
            this.SmallerIcons.Images.SetKeyName(4, "properties.ico");
            this.SmallerIcons.Images.SetKeyName(5, "plus.ico");
            this.SmallerIcons.Images.SetKeyName(6, "minus.ico");
            // 
            // NoAppsLabel
            // 
            this.NoAppsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoAppsLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.NoAppsLabel.Location = new System.Drawing.Point(9, 120);
            this.NoAppsLabel.Name = "NoAppsLabel";
            this.NoAppsLabel.Size = new System.Drawing.Size(631, 138);
            this.NoAppsLabel.TabIndex = 0;
            this.NoAppsLabel.Text = "There are no RemoteApps hosted on this computer.\r\nClick + to add one.";
            this.NoAppsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoAppsLabel.Visible = false;
            // 
            // ToolsMenuStrip
            // 
            this.ToolsMenuStrip.AllowMerge = false;
            this.ToolsMenuStrip.AutoSize = false;
            this.ToolsMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.ToolsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.ToolsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolsMenuStrip.Name = "ToolsMenuStrip";
            this.ToolsMenuStrip.ShowItemToolTips = true;
            this.ToolsMenuStrip.Size = new System.Drawing.Size(655, 24);
            this.ToolsMenuStrip.TabIndex = 5;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRemoteAppadvancedToolStripMenuItem,
            this.ToolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewRemoteAppadvancedToolStripMenuItem
            // 
            this.NewRemoteAppadvancedToolStripMenuItem.Name = "NewRemoteAppadvancedToolStripMenuItem";
            this.NewRemoteAppadvancedToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.NewRemoteAppadvancedToolStripMenuItem.Text = "New RemoteApp (advanced)...";
            this.NewRemoteAppadvancedToolStripMenuItem.Click += new System.EventHandler(this.NewRemoteAppadvancedToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HostOptionsToolStripMenuItem,
            this.ToolStripSeparator3,
            this.BackupAllRemoteAppsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // HostOptionsToolStripMenuItem
            // 
            this.HostOptionsToolStripMenuItem.Name = "HostOptionsToolStripMenuItem";
            this.HostOptionsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.HostOptionsToolStripMenuItem.Text = "Host Options...";
            this.HostOptionsToolStripMenuItem.Click += new System.EventHandler(this.HostOptionsToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // BackupAllRemoteAppsToolStripMenuItem
            // 
            this.BackupAllRemoteAppsToolStripMenuItem.Name = "BackupAllRemoteAppsToolStripMenuItem";
            this.BackupAllRemoteAppsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.BackupAllRemoteAppsToolStripMenuItem.Text = "Backup all RemoteApps...";
            this.BackupAllRemoteAppsToolStripMenuItem.Click += new System.EventHandler(this.BackupAllRemoteAppsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSeparator1,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AboutToolStripMenuItem.Text = "About...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // BackupSaveFileDialog
            // 
            this.BackupSaveFileDialog.DefaultExt = "reg";
            this.BackupSaveFileDialog.Filter = "Windows Registry file|*.reg";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 317);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 317);
            this.panel2.TabIndex = 4;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(99, 9);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(136, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(31, 26);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.BackupAllRemoteAppsToolStripMenuItem_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.Location = new System.Drawing.Point(62, 9);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(31, 26);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(25, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(0, 65);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.Size = new System.Drawing.Size(655, 276);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // remoteAppCollectionBindingSource
            // 
            this.remoteAppCollectionBindingSource.DataSource = typeof(RemoteApplicationPublisher.RemoteAppCollection);
            // 
            // RemoteAppMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 341);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoAppsLabel);
            this.Controls.Add(this.ToolsMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolsMenuStrip;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "RemoteAppMainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "RemoteApp Tool";
            this.Load += new System.EventHandler(this.RemoteAppMainWindow_Load);
            this.Disposed += new System.EventHandler(this.RemoteAppMainWindow_Disposed);
            this.ToolsMenuStrip.ResumeLayout(false);
            this.ToolsMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteAppCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        internal ImageList SmallIcons;
        internal ImageList SmallerIcons;
        internal Label NoAppsLabel;
        internal MenuStrip ToolsMenuStrip;
        internal ToolStripMenuItem ToolsToolStripMenuItem;
        internal ToolStripMenuItem HostOptionsToolStripMenuItem;
        internal ToolStripMenuItem FileToolStripMenuItem;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem AboutToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem NewRemoteAppadvancedToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem BackupAllRemoteAppsToolStripMenuItem;
        internal SaveFileDialog BackupSaveFileDialog;
        private Panel panel1;
        private DataGridView dataGrid;
        private BindingSource remoteAppCollectionBindingSource;
        private Panel panel2;
        private Button buttonEdit;
        private Button buttonSave;
        private Button buttonRemove;
        private Button buttonAdd;
    }
}