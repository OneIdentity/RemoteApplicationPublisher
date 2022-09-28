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
            this.PathText = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.BrowsePath = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ShortNameText = new System.Windows.Forms.TextBox();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SmallerIcons
            // 
            this.SmallerIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
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
            this.CommandLineOptionCombo.Location = new System.Drawing.Point(18, 229);
            this.CommandLineOptionCombo.Name = "CommandLineOptionCombo";
            this.CommandLineOptionCombo.Size = new System.Drawing.Size(81, 23);
            this.CommandLineOptionCombo.TabIndex = 1;
            // 
            // CommandLineText
            // 
            this.CommandLineText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandLineText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandLineText.Location = new System.Drawing.Point(18, 283);
            this.CommandLineText.Name = "CommandLineText";
            this.CommandLineText.Size = new System.Drawing.Size(390, 23);
            this.CommandLineText.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label8.Location = new System.Drawing.Point(15, 210);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(129, 15);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Command Line Option";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label6.Location = new System.Drawing.Point(15, 263);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(151, 15);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Command Line Parameters";
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelEditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.CancelEditButton.FlatAppearance.BorderSize = 0;
            this.CancelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelEditButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.CancelEditButton.ImageList = this.SmallerIcons;
            this.CancelEditButton.Location = new System.Drawing.Point(263, 346);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(75, 34);
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
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.ImageList = this.SmallerIcons;
            this.SaveButton.Location = new System.Drawing.Point(350, 346);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 34);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PathText
            // 
            this.PathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathText.Location = new System.Drawing.Point(18, 177);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(360, 23);
            this.PathText.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label4.Location = new System.Drawing.Point(15, 157);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 15);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Application Path";
            // 
            // BrowsePath
            // 
            this.BrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowsePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BrowsePath.Image = ((System.Drawing.Image)(resources.GetObject("BrowsePath.Image")));
            this.BrowsePath.Location = new System.Drawing.Point(382, 175);
            this.BrowsePath.Name = "BrowsePath";
            this.BrowsePath.Size = new System.Drawing.Size(27, 27);
            this.BrowsePath.TabIndex = 2;
            this.BrowsePath.UseVisualStyleBackColor = false;
            this.BrowsePath.Click += new System.EventHandler(this.BrowsePath_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label12.Location = new System.Drawing.Point(15, 52);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(39, 15);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label3.Location = new System.Drawing.Point(15, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Full name";
            // 
            // ShortNameText
            // 
            this.ShortNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortNameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShortNameText.Location = new System.Drawing.Point(18, 71);
            this.ShortNameText.Name = "ShortNameText";
            this.ShortNameText.Size = new System.Drawing.Size(390, 23);
            this.ShortNameText.TabIndex = 1;
            this.ShortNameText.TextChanged += new System.EventHandler(this.ShortNameText_TextChanged);
            // 
            // FullNameText
            // 
            this.FullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameText.Location = new System.Drawing.Point(18, 124);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(390, 23);
            this.FullNameText.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(207, 28);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Application Properties";
            // 
            // RemoteAppEditWindow
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.CancelEditButton;
            this.ClientSize = new System.Drawing.Size(429, 391);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.CommandLineText);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.CommandLineOptionCombo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.BrowsePath);
            this.Controls.Add(this.FullNameText);
            this.Controls.Add(this.ShortNameText);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.CancelEditButton);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 430);
            this.Name = "RemoteAppEditWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publish Application";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        internal TextBox PathText;
        internal Label Label4;
        internal Button BrowsePath;
        internal Label Label12;
        internal Label Label3;
        internal TextBox ShortNameText;
        internal TextBox FullNameText;
        private Label labelTitle;
    }
}