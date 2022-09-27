
using System;
using System.Windows.Forms;

namespace RemoteApplicationPublisher
{

    public partial class RemoteAppAboutWindow : Form
    {
        private RemoteAppMainWindow _mainWindow;

        public RemoteAppAboutWindow(RemoteAppMainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void RemoteAppAboutWindow_Load(object sender, EventArgs e)
        {
            Text = "About " + _mainWindow.Title.Text;
            TitleLabel.Text = _mainWindow.Title.Text;
            VersionLabel.Text = "Version " + Application.ProductVersion.ToString();
        }

        private void SiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Process.Start(SiteLinkLabel.Text);
        }

        private void IconLibLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Process.Start(IconLibLinkLabel.Text);
        }

    }
}