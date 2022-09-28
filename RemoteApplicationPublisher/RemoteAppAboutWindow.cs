
using System;
using System.Diagnostics;
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
            VersionLabel.Text = "Version " + Application.ProductVersion.ToString();
        }

        private void SiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process proc = new Process ();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = SiteLinkLabel.Text;
                proc.Start ();
            }
            catch
            {
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}