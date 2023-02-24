﻿
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RemoteApplicationPublisher
{

    public partial class RemoteAppEditWindow : Form
    {

        private RemoteApp RemoteApp = new RemoteApp();
        private RemoteAppMainWindow _mainWindow;
        private string RemoteAppOriginalPath = string.Empty;
        private bool populatingEditDialog = false;

        // Hard coded for now. This needs to be found dynamically.
        private string remoteLauncher = @"C:\Program Files\OneIdentity\RemoteApp Launcher\OI-SG-RemoteApp-Launcher.exe";
        private string commandLineTemplate = @"--cmd ""{0}"" --args ""{{username}}{{password}}{{asset}}""";
        private string enableDebug = @"--enable-debug";

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

            // LoadValues() may set checkBoxOILauncher.Checked to true, which will trigger checkBoxOILauncher_CheckedChanged.
            // Method checkBoxOILauncher_CheckedChanged will change values in the edit dialog when checkBoxOILauncher gets checked.
            // We don't want those values to change just because the edit dialog is raised.  We temporarily set a bool here that
            // we check within checkBoxOILauncher_CheckedChanged to avoid changing those values.
            populatingEditDialog = true;
            LoadValues();
            populatingEditDialog = false;

            var dlgResult = ShowDialog();
            _mainWindow.ReloadApps();
            Dispose();
            return RemoteApp;
        }

        public RemoteApp CreateRemoteApp()
        {
            Text = "New RemoteApp";
            Size = MinimumSize;
            HelpSystem.SetupTips(this);
            radioButtonOptional.Checked = true;

            EditRemoteApp(new RemoteApp());

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
            FullNameText.Text = RemoteApp.FullName;
            PathText.Text = RemoteApp.Path;
            CommandLineText.Text = RemoteApp.CommandLine;
            switch (RemoteApp.CommandLineOption)
            {
                case 0:
                    radioButtonDisabled.Checked = true;
                    break;
                case 1:
                    radioButtonOptional.Checked = true;
                    break;
                case 2:
                    radioButtonEnforced.Checked = true;
                    break;
            }
            checkBoxOILauncher.Checked = RemoteApp.UseLauncher;

            checkBoxDebug.Checked = CommandLineText.Text.Contains(enableDebug);

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
                    else
                        RemoteApp.Name = ShortNameText.Text;
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
            RemoteApp.UseLauncher = Convert.ToBoolean(checkBoxOILauncher.Checked);

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

        private void SaveAndEditWindow()
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
                SaveRemoteApp(ShortNameText.Text.Trim(), FullNameText.Text, PathText.Text, PathText.Text, CommandLineText.Text, GetCommandLineOption(), PathText.Text, 0, 0);
                Text = "Properties of " + FullNameText.Text;
                ShowDialog();
            }
        }

        private int GetCommandLineOption()
        {
            var option = 1;
            if (radioButtonDisabled.Checked)
                option = 0;
            else if (radioButtonEnforced.Checked)
                option = 2;
            return option;
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
                SaveRemoteApp(ShortNameText.Text.Trim(), FullNameText.Text, PathText.Text, PathText.Text, CommandLineText.Text, GetCommandLineOption(), PathText.Text, 0, 0);
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
                SaveRemoteApp(ShortNameText.Text.Trim(), FullNameText.Text, PathText.Text, PathText.Text, CommandLineText.Text, GetCommandLineOption(), PathText.Text, 0, 0);
                Close();
            }
        }

        private void ShortNameText_TextChanged(object sender, EventArgs e)
        {
            RemoteAppFunction.ValidateAppName(ShortNameText);
        }

        private void checkBoxOILauncher_CheckedChanged(object sender, EventArgs e)
        {
            if (!populatingEditDialog)
            {
                if (checkBoxOILauncher.Checked)
                {
                    RemoteAppOriginalPath = PathText.Text;
                    PathText.Text = remoteLauncher;
                    radioButtonEnforced.Checked = true;
                    CommandLineText.Text = string.Format(commandLineTemplate, RemoteAppOriginalPath);
                }
                else
                {
                    var sra = new SystemRemoteApps();
                    var currentApp = sra.GetApp(ShortNameText.Text);
                    if (currentApp != null)
                    {
                        RemoteAppOriginalPath = currentApp.VPath;
                    }
                    PathText.Text = RemoteAppOriginalPath;
                    radioButtonOptional.Checked = true;
                    CommandLineText.Text = string.Empty;
                }
            }

            PathText.Enabled = !checkBoxOILauncher.Checked;
            BrowsePath.Enabled = !checkBoxOILauncher.Checked;
            panelOptions.Enabled = !checkBoxOILauncher.Checked;
        }

        private void PathText_TextChanged(object sender, EventArgs e)
        {
            this.textBoxFullPath.Text = this.PathText.Text + " " + this.CommandLineText.Text;
        }

        private void CommandLineText_TextChanged(object sender, EventArgs e)
        {
            this.textBoxFullPath.Text = this.PathText.Text + " " + this.CommandLineText.Text;
        }

        private void checkBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDebug.Checked && !this.CommandLineText.Text.Contains(enableDebug))
                this.CommandLineText.Text += enableDebug;
            if (!this.checkBoxDebug.Checked && this.CommandLineText.Text.Contains(enableDebug))
                this.CommandLineText.Text = this.CommandLineText.Text.Replace(enableDebug,"");
        }
    }
}