using System.Windows.Forms;

namespace RemoteApplicationPublisher
{
    public partial class RemoteAppEditWindow
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAppEditWindow));
            this.SmallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.CommandLineOptionCombo = new System.Windows.Forms.ComboBox();
            this.CommandLineText = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.FileBrowserPath = new System.Windows.Forms.OpenFileDialog();
            this.FileBrowserIcon = new System.Windows.Forms.OpenFileDialog();
            this.FileBrowserVPath = new System.Windows.Forms.OpenFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.ShortNameText = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.PathText = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.BrowsePath = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SmallerIcons
            // 
            this.SmallerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallerIcons.ImageStream")));
            this.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallerIcons.Images.SetKeyName(0, "favorites_16x16.png");
            this.SmallerIcons.Images.SetKeyName(1, "folder_16x16.png");
            this.SmallerIcons.Images.SetKeyName(2, "dotdotdot.ico");
            this.SmallerIcons.Images.SetKeyName(3, "inside_icons_azure_marker_map_socialize_base.ico");
            this.SmallerIcons.Images.SetKeyName(4, "pictures (1).ico");
            this.SmallerIcons.Images.SetKeyName(5, "pictures.ico");
            this.SmallerIcons.Images.SetKeyName(6, "arrows_line_connector_with_draw.png");
            this.SmallerIcons.Images.SetKeyName(7, "doc_file_document_manager_paper_phone.ico");
            this.SmallerIcons.Images.SetKeyName(8, "cross.ico");
            // 
            // CommandLineOptionCombo
            // 
            this.CommandLineOptionCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommandLineOptionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommandLineOptionCombo.FormattingEnabled = true;
            this.CommandLineOptionCombo.Items.AddRange(new object[] {
            "Disabled",
            "Optional",
            "Enforced"});
            this.CommandLineOptionCombo.Location = new System.Drawing.Point(139, 22);
            this.CommandLineOptionCombo.Name = "CommandLineOptionCombo";
            this.CommandLineOptionCombo.Size = new System.Drawing.Size(81, 23);
            this.CommandLineOptionCombo.TabIndex = 1;
            // 
            // CommandLineText
            // 
            this.CommandLineText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandLineText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CommandLineText.Location = new System.Drawing.Point(163, 53);
            this.CommandLineText.Name = "CommandLineText";
            this.CommandLineText.Size = new System.Drawing.Size(236, 23);
            this.CommandLineText.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(127, 15);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Command line option:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label6.Location = new System.Drawing.Point(6, 56);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(151, 15);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Command line parameters:";
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelEditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelEditButton.ImageIndex = 8;
            this.CancelEditButton.ImageList = this.SmallerIcons;
            this.CancelEditButton.Location = new System.Drawing.Point(269, 356);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(75, 29);
            this.CancelEditButton.TabIndex = 3;
            this.CancelEditButton.Text = "Cancel";
            this.CancelEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelEditButton.UseVisualStyleBackColor = false;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // FileBrowserPath
            // 
            this.FileBrowserPath.Filter = "Programs|*.exe;*.com;*.cmd;*.bat|All files|*.*";
            this.FileBrowserPath.Title = "Browse...";
            // 
            // FileBrowserIcon
            // 
            this.FileBrowserIcon.Filter = "Icons|*.exe;*.dll;*.ico|All files|*.*";
            this.FileBrowserIcon.Title = "Browse...";
            // 
            // FileBrowserVPath
            // 
            this.FileBrowserVPath.Filter = "Programs|*.exe;*.com;*.cmd;*.bat|All files|*.*";
            this.FileBrowserVPath.Title = "Browse...";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ImageIndex = 0;
            this.SaveButton.ImageList = this.SmallerIcons;
            this.SaveButton.Location = new System.Drawing.Point(350, 356);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(67, 29);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.FullNameText);
            this.GroupBox1.Controls.Add(this.ShortNameText);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(405, 91);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Title";
            // 
            // FullNameText
            // 
            this.FullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameText.Location = new System.Drawing.Point(72, 51);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(327, 23);
            this.FullNameText.TabIndex = 3;
            // 
            // ShortNameText
            // 
            this.ShortNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortNameText.Location = new System.Drawing.Point(72, 22);
            this.ShortNameText.Name = "ShortNameText";
            this.ShortNameText.Size = new System.Drawing.Size(327, 23);
            this.ShortNameText.TabIndex = 1;
            this.ShortNameText.TextChanged += new System.EventHandler(this.ShortNameText_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 54);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Full name:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(6, 25);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(42, 15);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Name:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.PathText);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.BrowsePath);
            this.GroupBox2.Location = new System.Drawing.Point(12, 109);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(405, 116);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Files";
            // 
            // PathText
            // 
            this.PathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathText.Location = new System.Drawing.Point(72, 22);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(294, 23);
            this.PathText.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 25);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 15);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "App path:";
            // 
            // BrowsePath
            // 
            this.BrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowsePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BrowsePath.ImageIndex = 1;
            this.BrowsePath.ImageList = this.SmallerIcons;
            this.BrowsePath.Location = new System.Drawing.Point(372, 20);
            this.BrowsePath.Name = "BrowsePath";
            this.BrowsePath.Size = new System.Drawing.Size(27, 27);
            this.BrowsePath.TabIndex = 2;
            this.BrowsePath.UseVisualStyleBackColor = false;
            this.BrowsePath.Click += new System.EventHandler(this.BrowsePath_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.CommandLineText);
            this.GroupBox3.Controls.Add(this.CommandLineOptionCombo);
            this.GroupBox3.Location = new System.Drawing.Point(12, 231);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(405, 119);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Options";
            // 
            // RemoteAppEditWindow
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CancelEditButton;
            this.ClientSize = new System.Drawing.Size(429, 391);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.CancelEditButton);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 430);
            this.Name = "RemoteAppEditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RemoteAppEditWindow";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
        internal ComboBox CommandLineOptionCombo;
        internal TextBox CommandLineText;
        internal Label Label8;
        internal Label Label6;
        internal ImageList SmallerIcons;
        internal Button SaveButton;
        internal Button CancelEditButton;
        internal OpenFileDialog FileBrowserPath;
        internal OpenFileDialog FileBrowserIcon;
        internal OpenFileDialog FileBrowserVPath;
        internal GroupBox GroupBox1;
        internal TextBox FullNameText;
        internal TextBox ShortNameText;
        internal Label Label3;
        internal Label Label12;
        internal GroupBox GroupBox2;
        internal TextBox PathText;
        internal Label Label4;
        internal Button BrowsePath;
        internal GroupBox GroupBox3;
    }
}