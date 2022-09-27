
using System;
using System.IO;
using System.Windows.Forms;

namespace RemoteApplicationPublisher
{

    public partial class RemoteAppEditWindow : Form
    {

        private RemoteApp RemoteApp = new RemoteApp();
        private RemoteAppMainWindow _mainWindow;

        public RemoteAppEditWindow(RemoteAppMainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        public RemoteApp EditRemoteApp(RemoteApp selectedRemoteApp)
        {
            HelpSystem.SetupTips(this);
            RemoteApp = selectedRemoteApp;
            Text = "Properties of " + RemoteApp.Name;
            Size = MinimumSize;
            HelpSystem.SetupTips(this);
            LoadValues();
            var dlgResult = ShowDialog();
            _mainWindow.ReloadApps();
            Dispose();
            return RemoteApp;
        }

        public RemoteApp CreateRemoteApp(bool advanced = false)
        {
            Text = "New RemoteApp";
            Size = MinimumSize;
            HelpSystem.SetupTips(this);
            CommandLineOptionCombo.SelectedIndex = 1;

            if (advanced)
            {
                ShowDialog();
            }
            else if (DoBrowsePath() == true)
            {
                SaveAndCloseOrWindow();
            }

            Dispose();
            return RemoteApp;
        }

        private void SetToolTips()
        {
            var toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(BrowsePath, "Browse for application");
        }

        public void LoadValues()
        {

            ShortNameText.Text = RemoteApp.Name;
            CommandLineOptionCombo.SelectedIndex = RemoteApp.CommandLineOption;

            FullNameText.Text = RemoteApp.FullName;
            PathText.Text = RemoteApp.Path;
            CommandLineText.Text = RemoteApp.CommandLine;
            CommandLineOptionCombo.SelectedIndex = RemoteApp.CommandLineOption;

            Icon = RemoteAppFunction.ReturnIcon(RemoteApp.Path);
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BrowsePath_Click(object sender, EventArgs e)
        {
            DoBrowsePath();
        }

        private bool DoBrowsePath()
        {
            bool DoBrowsePathRet = default;

            DoBrowsePathRet = false;

            if (File.Exists(PathText.Text))
                FileBrowserPath.InitialDirectory = Directory.GetParent(PathText.Text)?.FullName;
            if (FileBrowserPath.ShowDialog() == DialogResult.OK)
            {
                string FilePath = FileBrowserPath.FileName;
                PathText.Text = FilePath;
                RemoteApp.Path = FilePath;
                RemoteApp.IconPath = FilePath;
                if (FilePath.ToLower().EndsWith(".exe"))
                {
                    var title = RemoteAppFunction.GetEXETitle(FilePath);
                    if (string.IsNullOrEmpty(ShortNameText.Text))
                        RemoteApp.Name = RemoteAppFunction.FixShortAppName(title);
                    if (string.IsNullOrEmpty(FullNameText.Text))
                        RemoteApp.FullName = title;
                }
                LoadValues();
                DoBrowsePathRet = true;
            }

            return DoBrowsePathRet;
        }

        private void SaveRemoteApp(string ShortName, string FullName, string Path, string VPath, string CommandLine, int CommandLineSetting, string IconPath, int IconIndex, int ShowInTSWA)
        {

            var SysApps = new SystemRemoteApps();

            if (RemoteApp.Name is not null & !(Text == "New RemoteApp"))
            {
                if (!((RemoteApp.Name ?? "") == (ShortName ?? "")))
                    SysApps.RenameApp(RemoteApp.Name, ShortName);
            }

            RemoteApp.Name = ShortName;
            RemoteApp.FullName = FullName;
            RemoteApp.Path = Path;
            RemoteApp.VPath = VPath;
            RemoteApp.IconPath = IconPath;
            RemoteApp.IconIndex = IconIndex;
            RemoteApp.CommandLine = CommandLine;
            RemoteApp.CommandLineOption = CommandLineSetting;
            RemoteApp.TSWA = Convert.ToBoolean(ShowInTSWA);

            SysApps.SaveApp(RemoteApp);

        }

        private bool DoesAppExist(string AppName)
        {
            bool AppExists = false;

            var sra = new SystemRemoteApps();
            var AppCol = sra.GetAll();

            foreach (RemoteApp App in AppCol)
            {
                if ((App.Name ?? "") == (AppName ?? ""))
                    AppExists = true;
            }

            return AppExists;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveAndClose();
        }

        private void SaveAndCloseOrWindow()
        {
            if (string.IsNullOrEmpty(ShortNameText.Text))
            {
                MessageBox.Show("Name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ShowDialog();
            }
            else if (string.IsNullOrEmpty(FullNameText.Text))
            {
                MessageBox.Show("Full name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ShowDialog();
            }
            else if (string.IsNullOrEmpty(PathText.Text))
            {
                MessageBox.Show("Path must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ShowDialog();
            }
            else if (!((ShortNameText.Text ?? "") == (RemoteApp.Name ?? "")) & DoesAppExist(ShortNameText.Text))
            {
                MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ShowDialog();
            }
            else if (Text == "New RemoteApp" & DoesAppExist(ShortNameText.Text))
            {
                MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ShowDialog();
            }
            else
            {
                SaveRemoteApp(ShortNameText.Text.Trim(), FullNameText.Text, PathText.Text, PathText.Text, CommandLineText.Text, CommandLineOptionCombo.SelectedIndex, PathText.Text, 0, 0);
                Close();
            }
        }

        private void SaveAndClose()
        {
            if (string.IsNullOrEmpty(ShortNameText.Text))
            {
                MessageBox.Show("Name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(FullNameText.Text))
            {
                MessageBox.Show("Full name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(PathText.Text))
            {
                MessageBox.Show("Path must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!((ShortNameText.Text ?? "") == (RemoteApp.Name ?? "")) & DoesAppExist(ShortNameText.Text))
            {
                MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (Text == "New RemoteApp" & DoesAppExist(ShortNameText.Text))
            {
                MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                SaveRemoteApp(ShortNameText.Text.Trim(), FullNameText.Text, PathText.Text, PathText.Text, CommandLineText.Text, CommandLineOptionCombo.SelectedIndex, PathText.Text, 0, 0);
                Close();
            }
        }

        private void ShortNameText_TextChanged(object sender, EventArgs e)
        {
            RemoteAppFunction.ValidateAppName(ShortNameText);
        }

    }
}