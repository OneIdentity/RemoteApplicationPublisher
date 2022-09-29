using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAppHostOptions));
            this.TimeoutDisconnectedCheckBox = new System.Windows.Forms.CheckBox();
            this.DisableAllowListCheckBox = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TimeoutIdleCheckBox = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.LogoffWhenTimoutCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SmallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.Label3 = new System.Windows.Forms.Label();
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.AllowUnlistedRemoteProgramsCheckBox = new System.Windows.Forms.CheckBox();
            this.disconnectTimeCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.idleTimeCounter = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectTimeCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idleTimeCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeoutDisconnectedCheckBox
            // 
            this.TimeoutDisconnectedCheckBox.AutoSize = true;
            this.TimeoutDisconnectedCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeoutDisconnectedCheckBox.Location = new System.Drawing.Point(14, 102);
            this.TimeoutDisconnectedCheckBox.Name = "TimeoutDisconnectedCheckBox";
            this.TimeoutDisconnectedCheckBox.Size = new System.Drawing.Size(211, 19);
            this.TimeoutDisconnectedCheckBox.TabIndex = 2;
            this.TimeoutDisconnectedCheckBox.Text = "Timeout for disconnected sessions:";
            this.TimeoutDisconnectedCheckBox.UseVisualStyleBackColor = true;
            this.TimeoutDisconnectedCheckBox.CheckedChanged += new System.EventHandler(this.TimeoutDisconnectedCheckBox_CheckedChanged);
            // 
            // DisableAllowListCheckBox
            // 
            this.DisableAllowListCheckBox.AutoSize = true;
            this.DisableAllowListCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DisableAllowListCheckBox.Location = new System.Drawing.Point(14, 52);
            this.DisableAllowListCheckBox.Name = "DisableAllowListCheckBox";
            this.DisableAllowListCheckBox.Size = new System.Drawing.Size(137, 19);
            this.DisableAllowListCheckBox.TabIndex = 0;
            this.DisableAllowListCheckBox.Text = "Disable AppAllowList";
            this.DisableAllowListCheckBox.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label1.Location = new System.Drawing.Point(310, 102);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 15);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "seconds";
            // 
            // TimeoutIdleCheckBox
            // 
            this.TimeoutIdleCheckBox.AutoSize = true;
            this.TimeoutIdleCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TimeoutIdleCheckBox.Location = new System.Drawing.Point(14, 129);
            this.TimeoutIdleCheckBox.Name = "TimeoutIdleCheckBox";
            this.TimeoutIdleCheckBox.Size = new System.Drawing.Size(159, 19);
            this.TimeoutIdleCheckBox.TabIndex = 5;
            this.TimeoutIdleCheckBox.Text = "Timeout for idle sessions:";
            this.TimeoutIdleCheckBox.UseVisualStyleBackColor = true;
            this.TimeoutIdleCheckBox.CheckedChanged += new System.EventHandler(this.TimeoutIdleCheckBox_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label2.Location = new System.Drawing.Point(261, 130);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 15);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "seconds";
            // 
            // LogoffWhenTimoutCheckBox
            // 
            this.LogoffWhenTimoutCheckBox.AutoSize = true;
            this.LogoffWhenTimoutCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoffWhenTimoutCheckBox.Location = new System.Drawing.Point(14, 155);
            this.LogoffWhenTimoutCheckBox.Name = "LogoffWhenTimoutCheckBox";
            this.LogoffWhenTimoutCheckBox.Size = new System.Drawing.Size(262, 19);
            this.LogoffWhenTimoutCheckBox.TabIndex = 8;
            this.LogoffWhenTimoutCheckBox.Text = "Logoff sessions when time limits are reached";
            this.LogoffWhenTimoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.ImageList = this.SmallerIcons;
            this.SaveButton.Location = new System.Drawing.Point(334, 241);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 34);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SmallerIcons
            // 
            this.SmallerIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.SmallerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallerIcons.ImageStream")));
            this.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallerIcons.Images.SetKeyName(0, "favorites_16x16.png");
            this.SmallerIcons.Images.SetKeyName(1, "cross.ico");
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label3.Location = new System.Drawing.Point(18, 183);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(385, 33);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Settings here will be overridden by local policy and group policy. Some settings " +
    "require a reboot.";
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelEditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.CancelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelEditButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.CancelEditButton.ImageList = this.SmallerIcons;
            this.CancelEditButton.Location = new System.Drawing.Point(248, 241);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(75, 34);
            this.CancelEditButton.TabIndex = 10;
            this.CancelEditButton.Text = "Cancel";
            this.CancelEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelEditButton.UseVisualStyleBackColor = false;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // AllowUnlistedRemoteProgramsCheckBox
            // 
            this.AllowUnlistedRemoteProgramsCheckBox.AutoSize = true;
            this.AllowUnlistedRemoteProgramsCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AllowUnlistedRemoteProgramsCheckBox.Location = new System.Drawing.Point(14, 77);
            this.AllowUnlistedRemoteProgramsCheckBox.Name = "AllowUnlistedRemoteProgramsCheckBox";
            this.AllowUnlistedRemoteProgramsCheckBox.Size = new System.Drawing.Size(200, 19);
            this.AllowUnlistedRemoteProgramsCheckBox.TabIndex = 1;
            this.AllowUnlistedRemoteProgramsCheckBox.Text = "Allow Unlisted Remote Programs";
            this.AllowUnlistedRemoteProgramsCheckBox.UseVisualStyleBackColor = true;
            // 
            // disconnectTimeCounter
            // 
            this.disconnectTimeCounter.Location = new System.Drawing.Point(228, 99);
            this.disconnectTimeCounter.Name = "disconnectTimeCounter";
            this.disconnectTimeCounter.Size = new System.Drawing.Size(77, 23);
            this.disconnectTimeCounter.TabIndex = 12;
            this.disconnectTimeCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disconnectTimeCounter.ValueChanged += new System.EventHandler(this.disconnectTimeCounter_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 10);
            this.label4.TabIndex = 13;
            this.label4.Text = "*";
            // 
            // idleTimeCounter
            // 
            this.idleTimeCounter.Location = new System.Drawing.Point(178, 126);
            this.idleTimeCounter.Name = "idleTimeCounter";
            this.idleTimeCounter.Size = new System.Drawing.Size(77, 23);
            this.idleTimeCounter.TabIndex = 14;
            this.idleTimeCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.idleTimeCounter.ValueChanged += new System.EventHandler(this.idleTimeCounter_ValueChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(209)))));
            this.labelTitle.Location = new System.Drawing.Point(9, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 28);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Host Options";
            // 
            // RemoteAppHostOptions
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.CancelEditButton;
            this.ClientSize = new System.Drawing.Size(413, 286);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.idleTimeCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disconnectTimeCounter);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelEditButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.AllowUnlistedRemoteProgramsCheckBox);
            this.Controls.Add(this.DisableAllowListCheckBox);
            this.Controls.Add(this.LogoffWhenTimoutCheckBox);
            this.Controls.Add(this.TimeoutIdleCheckBox);
            this.Controls.Add(this.TimeoutDisconnectedCheckBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoteAppHostOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Host Options";
            ((System.ComponentModel.ISupportInitialize)(this.disconnectTimeCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idleTimeCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal CheckBox TimeoutDisconnectedCheckBox;
        internal CheckBox DisableAllowListCheckBox;
        internal Label Label1;
        internal CheckBox TimeoutIdleCheckBox;
        internal Label Label2;
        internal CheckBox LogoffWhenTimoutCheckBox;
        internal Button SaveButton;
        internal ImageList SmallerIcons;
        internal Label Label3;
        internal Button CancelEditButton;
        internal CheckBox AllowUnlistedRemoteProgramsCheckBox;
        private NumericUpDown disconnectTimeCounter;
        internal Label label4;
        private NumericUpDown idleTimeCounter;
        private Label labelTitle;
    }
}