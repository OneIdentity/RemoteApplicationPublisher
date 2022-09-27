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
            this.AppList = new System.Windows.Forms.ListView();
            this.ShortName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequiredCommandLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommandLineSetting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IconPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IconIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecurityDescriptor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowInTSWA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.SmallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.NoAppsLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackupSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppList
            // 
            this.AppList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.AppList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppList.BackColor = System.Drawing.Color.White;
            this.AppList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShortName,
            this.Title,
            this.Path,
            this.VPath,
            this.RequiredCommandLine,
            this.CommandLineSetting,
            this.IconPath,
            this.IconIndex,
            this.SecurityDescriptor,
            this.ShowInTSWA});
            this.AppList.GridLines = true;
            this.AppList.HideSelection = false;
            this.AppList.LargeImageList = this.SmallIcons;
            this.AppList.Location = new System.Drawing.Point(12, 28);
            this.AppList.MultiSelect = false;
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(423, 189);
            this.AppList.SmallImageList = this.SmallIcons;
            this.AppList.TabIndex = 1;
            this.AppList.TileSize = new System.Drawing.Size(200, 36);
            this.AppList.UseCompatibleStateImageBehavior = false;
            this.AppList.View = System.Windows.Forms.View.Tile;
            this.AppList.SelectedIndexChanged += new System.EventHandler(this.AppList_SelectedIndexChanged);
            this.AppList.DoubleClick += new System.EventHandler(this.AppList_DoubleClick);
            // 
            // ShortName
            // 
            this.ShortName.Text = "ShortName";
            this.ShortName.Width = 200;
            // 
            // Title
            // 
            this.Title.Text = "Name";
            // 
            // Path
            // 
            this.Path.Text = "Path";
            // 
            // VPath
            // 
            this.VPath.Text = "VPath";
            // 
            // RequiredCommandLine
            // 
            this.RequiredCommandLine.Text = "RequiredCommandLine";
            // 
            // CommandLineSetting
            // 
            this.CommandLineSetting.Text = "CommandLineSetting";
            // 
            // IconPath
            // 
            this.IconPath.Text = "IconPath";
            // 
            // IconIndex
            // 
            this.IconIndex.Text = "IconIndex";
            // 
            // SecurityDescriptor
            // 
            this.SecurityDescriptor.Text = "SecurityDescriptor";
            // 
            // ShowInTSWA
            // 
            this.ShowInTSWA.Text = "ShowInTSWA";
            // 
            // SmallIcons
            // 
            this.SmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcons.ImageStream")));
            this.SmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcons.Images.SetKeyName(0, "smallicons.ico");
            // 
            // SmallerIcons
            // 
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
            this.NoAppsLabel.Location = new System.Drawing.Point(12, 91);
            this.NoAppsLabel.Name = "NoAppsLabel";
            this.NoAppsLabel.Size = new System.Drawing.Size(410, 58);
            this.NoAppsLabel.TabIndex = 0;
            this.NoAppsLabel.Text = "There are no RemoteApps hosted on this computer.\r\nClick + to add one.";
            this.NoAppsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoAppsLabel.Visible = false;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.AutoSize = true;
            this.CreateButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.ImageIndex = 5;
            this.CreateButton.ImageList = this.SmallerIcons;
            this.CreateButton.Location = new System.Drawing.Point(12, 227);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(22, 22);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ImageIndex = 6;
            this.DeleteButton.ImageList = this.SmallerIcons;
            this.DeleteButton.Location = new System.Drawing.Point(40, 227);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(22, 22);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.AutoSize = true;
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.Enabled = false;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditButton.ImageIndex = 4;
            this.EditButton.ImageList = this.SmallerIcons;
            this.EditButton.Location = new System.Drawing.Point(68, 227);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(22, 22);
            this.EditButton.TabIndex = 4;
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.ToolsMenuStrip.Size = new System.Drawing.Size(434, 24);
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
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "About...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(-1, 27);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(435, 191);
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            // 
            // BackupSaveFileDialog
            // 
            this.BackupSaveFileDialog.DefaultExt = "reg";
            this.BackupSaveFileDialog.Filter = "Windows Registry file|*.reg";
            // 
            // RemoteAppMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.NoAppsLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ToolsMenuStrip);
            this.Controls.Add(this.AppList);
            this.Controls.Add(this.PictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal ListView AppList;
        internal ColumnHeader ShortName;
        internal ColumnHeader Title;
        internal ColumnHeader Path;
        internal ColumnHeader VPath;
        internal ColumnHeader RequiredCommandLine;
        internal ColumnHeader CommandLineSetting;
        internal ColumnHeader IconPath;
        internal ColumnHeader IconIndex;
        internal ColumnHeader SecurityDescriptor;
        internal ColumnHeader ShowInTSWA;
        internal ImageList SmallIcons;
        internal Button CreateButton;
        internal ImageList SmallerIcons;
        internal Button DeleteButton;
        internal Button EditButton;
        internal Label NoAppsLabel;
        internal MenuStrip ToolsMenuStrip;
        internal ToolStripMenuItem ToolsToolStripMenuItem;
        internal ToolStripMenuItem HostOptionsToolStripMenuItem;
        internal ToolStripMenuItem FileToolStripMenuItem;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem AboutToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal PictureBox PictureBox1;
        internal ToolStripMenuItem NewRemoteAppadvancedToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem BackupAllRemoteAppsToolStripMenuItem;
        internal SaveFileDialog BackupSaveFileDialog;
    }
}