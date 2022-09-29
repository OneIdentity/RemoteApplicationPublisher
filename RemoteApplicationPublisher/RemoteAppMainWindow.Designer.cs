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
            this.SmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.SmallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.NoAppsLabel = new System.Windows.Forms.Label();
            this.ToolsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.BackupSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSettingsMenu = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.remoteAppCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextSettingsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backupApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AppList = new System.Windows.Forms.ListView();
            this.ShortName = new System.Windows.Forms.ColumnHeader();
            this.FullName = new System.Windows.Forms.ColumnHeader();
            this.ProgramPath = new System.Windows.Forms.ColumnHeader();
            this.CommandLine = new System.Windows.Forms.ColumnHeader();
            this.labelSeparator1 = new System.Windows.Forms.Label();
            this.listViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remoteAppCollectionBindingSource)).BeginInit();
            this.contextSettingsMenuStrip.SuspendLayout();
            this.listViewContextMenuStrip.SuspendLayout();
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
            this.NoAppsLabel.Location = new System.Drawing.Point(12, 144);
            this.NoAppsLabel.Name = "NoAppsLabel";
            this.NoAppsLabel.Size = new System.Drawing.Size(631, 73);
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
            this.ToolsMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolsMenuStrip.Name = "ToolsMenuStrip";
            this.ToolsMenuStrip.ShowItemToolTips = true;
            this.ToolsMenuStrip.Size = new System.Drawing.Size(655, 37);
            this.ToolsMenuStrip.TabIndex = 5;
            // 
            // BackupSaveFileDialog
            // 
            this.BackupSaveFileDialog.DefaultExt = "reg";
            this.BackupSaveFileDialog.Filter = "Windows Registry file|*.reg";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonSettingsMenu);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 37);
            this.panel1.TabIndex = 8;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(84, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(31, 26);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // buttonSettingsMenu
            // 
            this.buttonSettingsMenu.FlatAppearance.BorderSize = 0;
            this.buttonSettingsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettingsMenu.Image")));
            this.buttonSettingsMenu.Location = new System.Drawing.Point(612, 3);
            this.buttonSettingsMenu.Name = "buttonSettingsMenu";
            this.buttonSettingsMenu.Size = new System.Drawing.Size(31, 26);
            this.buttonSettingsMenu.TabIndex = 3;
            this.buttonSettingsMenu.UseVisualStyleBackColor = true;
            this.buttonSettingsMenu.Click += new System.EventHandler(this.buttonSettingsMenu_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.Location = new System.Drawing.Point(47, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(31, 26);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(10, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(31, 26);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // contextSettingsMenuStrip
            // 
            this.contextSettingsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupApplicationsToolStripMenuItem,
            this.hostOptionsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.contextSettingsMenuStrip.Name = "contextSettingsMenuStrip";
            this.contextSettingsMenuStrip.Size = new System.Drawing.Size(209, 70);
            // 
            // backupApplicationsToolStripMenuItem
            // 
            this.backupApplicationsToolStripMenuItem.Name = "backupApplicationsToolStripMenuItem";
            this.backupApplicationsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.backupApplicationsToolStripMenuItem.Text = "Backup All Applications...";
            this.backupApplicationsToolStripMenuItem.Click += new System.EventHandler(this.backupApplicationsToolStripMenuItem_Click);
            // 
            // hostOptionsToolStripMenuItem
            // 
            this.hostOptionsToolStripMenuItem.Name = "hostOptionsToolStripMenuItem";
            this.hostOptionsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hostOptionsToolStripMenuItem.Text = "Host Options...";
            this.hostOptionsToolStripMenuItem.Click += new System.EventHandler(this.HostOptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.aboutToolStripMenuItem1.Text = "About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // AppList
            // 
            this.AppList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppList.BackColor = System.Drawing.Color.White;
            this.AppList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShortName,
            this.FullName,
            this.ProgramPath,
            this.CommandLine});
            this.AppList.FullRowSelect = true;
            this.AppList.LargeImageList = this.SmallIcons;
            this.AppList.Location = new System.Drawing.Point(10, 46);
            this.AppList.MultiSelect = false;
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(644, 295);
            this.AppList.SmallImageList = this.SmallIcons;
            this.AppList.TabIndex = 1;
            this.AppList.UseCompatibleStateImageBehavior = false;
            this.AppList.View = System.Windows.Forms.View.Details;
            this.AppList.SelectedIndexChanged += new System.EventHandler(this.AppList_SelectedIndexChanged);
            this.AppList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppList_MouseDown);
            // 
            // ShortName
            // 
            this.ShortName.Text = "Name";
            this.ShortName.Width = 140;
            // 
            // FullName
            // 
            this.FullName.Text = "Full Name";
            this.FullName.Width = 140;
            // 
            // ProgramPath
            // 
            this.ProgramPath.Text = "Program Path";
            this.ProgramPath.Width = 120;
            // 
            // CommandLine
            // 
            this.CommandLine.Text = "CommandLine";
            this.CommandLine.Width = 400;
            // 
            // labelSeparator1
            // 
            this.labelSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeparator1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeparator1.Location = new System.Drawing.Point(0, 40);
            this.labelSeparator1.Name = "labelSeparator1";
            this.labelSeparator1.Size = new System.Drawing.Size(655, 1);
            this.labelSeparator1.TabIndex = 10;
            // 
            // listViewContextMenuStrip
            // 
            this.listViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.listViewContextMenuStrip.Name = "listViewContextMenuStrip";
            this.listViewContextMenuStrip.Size = new System.Drawing.Size(173, 26);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // RemoteAppMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 341);
            this.Controls.Add(this.labelSeparator1);
            this.Controls.Add(this.AppList);
            this.Controls.Add(this.NoAppsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolsMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "RemoteAppMainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Remote Application Publisher";
            this.Load += new System.EventHandler(this.RemoteAppMainWindow_Load);
            this.Disposed += new System.EventHandler(this.RemoteAppMainWindow_Disposed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remoteAppCollectionBindingSource)).EndInit();
            this.contextSettingsMenuStrip.ResumeLayout(false);
            this.listViewContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal ImageList SmallIcons;
        internal ImageList SmallerIcons;
        internal Label NoAppsLabel;
        internal MenuStrip ToolsMenuStrip;
        internal SaveFileDialog BackupSaveFileDialog;
        private Panel panel1;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonAdd;
        private BindingSource remoteAppCollectionBindingSource;
        private Button buttonSettingsMenu;
        private ContextMenuStrip contextSettingsMenuStrip;
        private ToolStripMenuItem backupApplicationsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        internal ListView AppList;
        private Label labelSeparator1;
        internal ColumnHeader ShortName;
        internal ColumnHeader FullName;
        internal ColumnHeader CommandLine;
        private ColumnHeader ProgramPath;
        private ContextMenuStrip listViewContextMenuStrip;
        private ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private ToolStripMenuItem hostOptionsToolStripMenuItem;
    }
}