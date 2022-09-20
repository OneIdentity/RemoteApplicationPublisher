namespace RemoteApplicationPublisher
{
    public partial class RemoteAppHostOptions : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAppHostOptions));
            TimeoutDisconnectedCheckBox = new CheckBox();
            TimeoutDisconnectedCheckBox.CheckedChanged += new EventHandler(TimeoutDisconnectedCheckBox_CheckedChanged);
            DisableAllowListCheckBox = new CheckBox();
            DisconnectTimeTextBox = new TextBox();
            DisconnectTimeTextBox.TextChanged += new EventHandler(DisconnectTimeTextBox_TextChanged);
            Label1 = new Label();
            TimeoutIdleCheckBox = new CheckBox();
            TimeoutIdleCheckBox.CheckedChanged += new EventHandler(TimeoutIdleCheckBox_CheckedChanged);
            IdleTimeTextBox = new TextBox();
            IdleTimeTextBox.TextChanged += new EventHandler(IdleTimeTextBox_TextChanged);
            Label2 = new Label();
            LogoffWhenTimoutCheckBox = new CheckBox();
            SaveButton = new Button();
            SaveButton.Click += new EventHandler(SaveButton_Click);
            SmallerIcons = new ImageList(components);
            Label3 = new Label();
            CancelEditButton = new Button();
            CancelEditButton.Click += new EventHandler(CancelEditButton_Click);
            AllowUnlistedRemoteProgramsCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // TimeoutDisconnectedCheckBox
            // 
            TimeoutDisconnectedCheckBox.AutoSize = true;
            TimeoutDisconnectedCheckBox.Location = new Point(14, 64);
            TimeoutDisconnectedCheckBox.Name = "TimeoutDisconnectedCheckBox";
            TimeoutDisconnectedCheckBox.Size = new Size(211, 19);
            TimeoutDisconnectedCheckBox.TabIndex = 2;
            TimeoutDisconnectedCheckBox.Text = "Timeout for disconnected sessions:";
            TimeoutDisconnectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DisableAllowListCheckBox
            // 
            DisableAllowListCheckBox.AutoSize = true;
            DisableAllowListCheckBox.Location = new Point(14, 14);
            DisableAllowListCheckBox.Name = "DisableAllowListCheckBox";
            DisableAllowListCheckBox.Size = new Size(137, 19);
            DisableAllowListCheckBox.TabIndex = 0;
            DisableAllowListCheckBox.Text = "Disable AppAllowList";
            DisableAllowListCheckBox.UseVisualStyleBackColor = true;
            // 
            // DisconnectTimeTextBox
            // 
            DisconnectTimeTextBox.Location = new Point(245, 62);
            DisconnectTimeTextBox.MaxLength = 8;
            DisconnectTimeTextBox.Name = "DisconnectTimeTextBox";
            DisconnectTimeTextBox.Size = new Size(83, 23);
            DisconnectTimeTextBox.TabIndex = 3;
            DisconnectTimeTextBox.Text = "0";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(336, 66);
            Label1.Name = "Label1";
            Label1.Size = new Size(50, 15);
            Label1.TabIndex = 4;
            Label1.Text = "seconds";
            // 
            // TimeoutIdleCheckBox
            // 
            TimeoutIdleCheckBox.AutoSize = true;
            TimeoutIdleCheckBox.Location = new Point(14, 91);
            TimeoutIdleCheckBox.Name = "TimeoutIdleCheckBox";
            TimeoutIdleCheckBox.Size = new Size(159, 19);
            TimeoutIdleCheckBox.TabIndex = 5;
            TimeoutIdleCheckBox.Text = "Timeout for idle sessions:";
            TimeoutIdleCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdleTimeTextBox
            // 
            IdleTimeTextBox.Location = new Point(189, 89);
            IdleTimeTextBox.MaxLength = 8;
            IdleTimeTextBox.Name = "IdleTimeTextBox";
            IdleTimeTextBox.Size = new Size(83, 23);
            IdleTimeTextBox.TabIndex = 6;
            IdleTimeTextBox.Text = "0";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(280, 91);
            Label2.Name = "Label2";
            Label2.Size = new Size(50, 15);
            Label2.TabIndex = 7;
            Label2.Text = "seconds";
            // 
            // LogoffWhenTimoutCheckBox
            // 
            LogoffWhenTimoutCheckBox.AutoSize = true;
            LogoffWhenTimoutCheckBox.Location = new Point(14, 117);
            LogoffWhenTimoutCheckBox.Name = "LogoffWhenTimoutCheckBox";
            LogoffWhenTimoutCheckBox.Size = new Size(262, 19);
            LogoffWhenTimoutCheckBox.TabIndex = 8;
            LogoffWhenTimoutCheckBox.Text = "Logoff sessions when time limits are reached";
            LogoffWhenTimoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.WhiteSmoke;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.ImageIndex = 0;
            SaveButton.ImageList = SmallerIcons;
            SaveButton.Location = new Point(334, 190);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(67, 29);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // SmallerIcons
            // 
            SmallerIcons.ImageStream = (ImageListStreamer)resources.GetObject("SmallerIcons.ImageStream");
            SmallerIcons.TransparentColor = Color.Transparent;
            SmallerIcons.Images.SetKeyName(0, "favorites_16x16.png");
            SmallerIcons.Images.SetKeyName(1, "cross.ico");
            // 
            // Label3
            // 
            Label3.Font = new Font("Segoe UI", 9.0f);
            Label3.ForeColor = Color.Maroon;
            Label3.Location = new Point(11, 145);
            Label3.Name = "Label3";
            Label3.Size = new Size(385, 33);
            Label3.TabIndex = 9;
            Label3.Text = "Note: Settings here will be overridden by local policy and group policy. Some set" + "tings require a reboot.";
            // 
            // CancelEditButton
            // 
            CancelEditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelEditButton.BackColor = Color.WhiteSmoke;
            CancelEditButton.DialogResult = DialogResult.Cancel;
            CancelEditButton.ImageIndex = 1;
            CancelEditButton.ImageList = SmallerIcons;
            CancelEditButton.Location = new Point(253, 190);
            CancelEditButton.Name = "CancelEditButton";
            CancelEditButton.Size = new Size(75, 29);
            CancelEditButton.TabIndex = 10;
            CancelEditButton.Text = "Cancel";
            CancelEditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelEditButton.UseVisualStyleBackColor = false;
            // 
            // AllowUnlistedRemoteProgramsCheckBox
            // 
            AllowUnlistedRemoteProgramsCheckBox.AutoSize = true;
            AllowUnlistedRemoteProgramsCheckBox.Location = new Point(14, 39);
            AllowUnlistedRemoteProgramsCheckBox.Name = "AllowUnlistedRemoteProgramsCheckBox";
            AllowUnlistedRemoteProgramsCheckBox.Size = new Size(200, 19);
            AllowUnlistedRemoteProgramsCheckBox.TabIndex = 1;
            AllowUnlistedRemoteProgramsCheckBox.Text = "Allow Unlisted Remote Programs";
            AllowUnlistedRemoteProgramsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RemoteAppHostOptions
            // 
            AcceptButton = SaveButton;
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = CancelEditButton;
            ClientSize = new Size(413, 231);
            Controls.Add(SaveButton);
            Controls.Add(CancelEditButton);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(IdleTimeTextBox);
            Controls.Add(DisconnectTimeTextBox);
            Controls.Add(AllowUnlistedRemoteProgramsCheckBox);
            Controls.Add(DisableAllowListCheckBox);
            Controls.Add(LogoffWhenTimoutCheckBox);
            Controls.Add(TimeoutIdleCheckBox);
            Controls.Add(TimeoutDisconnectedCheckBox);
            Font = new Font("Segoe UI", 9.0f);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoteAppHostOptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Host Options";
            ResumeLayout(false);
            PerformLayout();

        }
        internal CheckBox TimeoutDisconnectedCheckBox;
        internal CheckBox DisableAllowListCheckBox;
        internal TextBox DisconnectTimeTextBox;
        internal Label Label1;
        internal CheckBox TimeoutIdleCheckBox;
        internal TextBox IdleTimeTextBox;
        internal Label Label2;
        internal CheckBox LogoffWhenTimoutCheckBox;
        internal Button SaveButton;
        internal ImageList SmallerIcons;
        internal Label Label3;
        internal Button CancelEditButton;
        internal CheckBox AllowUnlistedRemoteProgramsCheckBox;
    }
}