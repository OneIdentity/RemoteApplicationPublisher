using System;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteApplicationPublisher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class RemoteAppAboutWindow : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteAppAboutWindow));
            TitleLabel = new Label();
            VersionLabel = new Label();
            CopyrightLabel = new Label();
            SiteLinkLabel = new LinkLabel();
            SiteLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(SiteLinkLabel_LinkClicked);
            IconLibCreatedByLabel = new Label();
            IconLibLabel = new Label();
            IconLibLinkLabel = new LinkLabel();
            IconLibLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(IconLibLinkLabel_LinkClicked);
            IconLibLicenceTextLabel = new Label();
            RemoteAppToolLicenceTextLabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top;
            TitleLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(17, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(263, 30);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "RemoteApp Tool";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Top;
            VersionLabel.Location = new Point(17, 39);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(263, 30);
            VersionLabel.TabIndex = 0;
            VersionLabel.Text = "Version 0.0.0.0";
            VersionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CopyrightLabel
            // 
            CopyrightLabel.Anchor = AnchorStyles.Top;
            CopyrightLabel.Location = new Point(17, 69);
            CopyrightLabel.Name = "CopyrightLabel";
            CopyrightLabel.Size = new Size(263, 30);
            CopyrightLabel.TabIndex = 0;
            CopyrightLabel.Text = "Kim Knight, Brian Gale";
            CopyrightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiteLinkLabel
            // 
            SiteLinkLabel.Anchor = AnchorStyles.Top;
            SiteLinkLabel.Location = new Point(15, 129);
            SiteLinkLabel.Name = "SiteLinkLabel";
            SiteLinkLabel.Size = new Size(271, 30);
            SiteLinkLabel.TabIndex = 1;
            SiteLinkLabel.TabStop = true;
            SiteLinkLabel.Text = "https://github.com/kimmknight/remoteapptool";
            SiteLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IconLibCreatedByLabel
            // 
            IconLibCreatedByLabel.Anchor = AnchorStyles.Top;
            IconLibCreatedByLabel.Location = new Point(17, 189);
            IconLibCreatedByLabel.Name = "IconLibCreatedByLabel";
            IconLibCreatedByLabel.Size = new Size(263, 30);
            IconLibCreatedByLabel.TabIndex = 4;
            IconLibCreatedByLabel.Text = "Created by CastorTiu";
            IconLibCreatedByLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IconLibLabel
            // 
            IconLibLabel.Anchor = AnchorStyles.Top;
            IconLibLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            IconLibLabel.Location = new Point(17, 159);
            IconLibLabel.Name = "IconLibLabel";
            IconLibLabel.Size = new Size(263, 30);
            IconLibLabel.TabIndex = 5;
            IconLibLabel.Text = "IconLib";
            IconLibLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IconLibLinkLabel
            // 
            IconLibLinkLabel.Anchor = AnchorStyles.Top;
            IconLibLinkLabel.Location = new Point(12, 249);
            IconLibLinkLabel.Name = "IconLibLinkLabel";
            IconLibLinkLabel.Size = new Size(274, 30);
            IconLibLinkLabel.TabIndex = 1;
            IconLibLinkLabel.TabStop = true;
            IconLibLinkLabel.Text = "https://creativecommons.org/licenses/by-sa/3.0/";
            IconLibLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IconLibLicenceTextLabel
            // 
            IconLibLicenceTextLabel.Anchor = AnchorStyles.Top;
            IconLibLicenceTextLabel.Location = new Point(17, 219);
            IconLibLicenceTextLabel.Name = "IconLibLicenceTextLabel";
            IconLibLicenceTextLabel.Size = new Size(263, 30);
            IconLibLicenceTextLabel.TabIndex = 4;
            IconLibLicenceTextLabel.Text = "Licensed under a Creative Commons" + '\r' + '\n' + "Attribution-Share Alike 3.0 Unported License";
            IconLibLicenceTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoteAppToolLicenceTextLabel
            // 
            RemoteAppToolLicenceTextLabel.Anchor = AnchorStyles.Top;
            RemoteAppToolLicenceTextLabel.Location = new Point(17, 99);
            RemoteAppToolLicenceTextLabel.Name = "RemoteAppToolLicenceTextLabel";
            RemoteAppToolLicenceTextLabel.Size = new Size(263, 30);
            RemoteAppToolLicenceTextLabel.TabIndex = 6;
            RemoteAppToolLicenceTextLabel.Text = "Licensed under The MIT License";
            RemoteAppToolLicenceTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoteAppAboutWindow
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(298, 296);
            Controls.Add(RemoteAppToolLicenceTextLabel);
            Controls.Add(IconLibLicenceTextLabel);
            Controls.Add(IconLibCreatedByLabel);
            Controls.Add(IconLibLabel);
            Controls.Add(IconLibLinkLabel);
            Controls.Add(SiteLinkLabel);
            Controls.Add(CopyrightLabel);
            Controls.Add(VersionLabel);
            Controls.Add(TitleLabel);
            Font = new Font("Segoe UI", 9.0f);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoteAppAboutWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RemoteAppAboutWindow";
            Load += new EventHandler(RemoteAppAboutWindow_Load);
            ResumeLayout(false);

        }
        internal Label TitleLabel;
        internal Label VersionLabel;
        internal Label CopyrightLabel;
        internal LinkLabel SiteLinkLabel;
        internal Label IconLibCreatedByLabel;
        internal Label IconLibLabel;
        internal LinkLabel IconLibLinkLabel;
        internal Label IconLibLicenceTextLabel;
        internal Label RemoteAppToolLicenceTextLabel;
    }
}