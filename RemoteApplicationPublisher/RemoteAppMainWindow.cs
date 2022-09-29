using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteApplicationPublisher
{
    public partial class RemoteAppMainWindow : Form
    {
        public RemoteAppMainWindow()
        {
            InitializeComponent();
            this.dataGrid.ColumnCount = 3;
            this.dataGrid.Columns[0].Name = "Application Name";
            this.dataGrid.Columns[1].Name = "Path";
            this.dataGrid.Columns[2].Name = "Command Line";

            this.dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.MultiSelect = false;
        }

        private void RemoteAppMainWindow_Disposed(object sender, EventArgs e)
        {
            if (!(WindowState == FormWindowState.Maximized))
            {
                Size = new Size(Width,Height);
            }
        }

        private void RemoteAppMainWindow_Load(object sender, EventArgs e)
        {
            var sra = new SystemRemoteApps();
            sra.Init();

            Text = Application.ProductName + " " + Application.ProductVersion + " (" + System.Net.Dns.GetHostName() + ")";
            HelpSystem.SetupTips(this);
            ReloadApps();
        }


        public void ReloadApps()
        {
//            AppList.Clear();

            var systemApps = new SystemRemoteApps();
            var apps = systemApps.GetAll();

            this.dataGrid.Rows.Clear();

            foreach (RemoteApp app in apps)
            {
                var columns = new string[3];
                columns[0] = app.Name;
                columns[1] = app.Path;
                columns[2] = app.CommandLine;
                this.dataGrid.Rows.Add(columns);
            //    SmallIcons.Images.RemoveByKey(app.Name);
            //    var iconBitmap = RemoteAppFunction.GetAppBitmap(app.Name);
            //    var appItem = new ListViewItem(app.Name);
            //    appItem.ToolTipText = app.FullName;
            //    appItem.ImageIndex = 0;
            //    SmallIcons.Images.Add(app.Name, iconBitmap);
            //    appItem.ImageKey = app.Name;
            //    AppList.Items.Add(appItem);
            }


            if (apps.Count == 0)
            {
                NoAppsLabel.Visible = true;
                buttonRemove.Enabled = false;
                buttonEdit.Enabled = false;
            }
            else
            {
                this.dataGrid.ClearSelection();
                NoAppsLabel.Visible = false;
                buttonRemove.Enabled = false;
                buttonEdit.Enabled = false;
            }

//            buttonRemove.Enabled = false;
//            buttonEdit.Enabled = false;
        }

        //private void AppList_DoubleClick(object sender, EventArgs e)
        //{
        //    if (AppList.SelectedItems.Count == 1)
        //    {
        //        EditRemoteApp(AppList.SelectedItems[0].Text);
        //    }
        //}

        string SelectedApplicationName;

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                SelectedApplicationName = row.Cells["Application Name"].Value.ToString();
                this.buttonEdit.Enabled = true;
                this.buttonRemove.Enabled = true;
            }

        }

        //private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (AppList.SelectedItems.Count == 1)
        //    {
        //        buttonRemove.Enabled = true;
        //        buttonEdit.Enabled = true;
        //    }
        //    else
        //    {
        //        buttonRemove.Enabled = false;
        //        buttonEdit.Enabled = false;
        //    }
        //}

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditRemoteApp(this.SelectedApplicationName);

            //if (AppList.SelectedItems.Count == 1)
            //{
            //    EditRemoteApp(AppList.SelectedItems[0].Text);
            //}
        }

        private void EditRemoteApp(string AppName)
        {
            var sra = new SystemRemoteApps();
            var remoteAppEditWindow = new RemoteAppEditWindow(this);
            remoteAppEditWindow.EditRemoteApp(sra.GetApp(AppName));
            ReloadApps();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteRemoteApp(this.SelectedApplicationName);
        }

        private void DeleteRemoteApp(string AppName)
        {
            if (MessageBox.Show("Are you sure you want to remove " + AppName + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sra = new SystemRemoteApps();
                sra.DeleteApp(AppName);
            }
            ReloadApps();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var remoteAppEditWindow = new RemoteAppEditWindow(this);
            remoteAppEditWindow.CreateRemoteApp();
            ReloadApps();
        }

        private void HostOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var remoteAppHostOptions = new RemoteAppHostOptions(this);
            remoteAppHostOptions.SetValues();
            remoteAppHostOptions.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var remoteAppAboutWindow = new RemoteAppAboutWindow(this);
            remoteAppAboutWindow.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NewRemoteAppadvancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var remoteAppEditWindow = new RemoteAppEditWindow(this);
            remoteAppEditWindow.CreateRemoteApp(true);
            ReloadApps();
        }

        private void BackupAllRemoteAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupSaveFileDialog.FileName = System.Net.Dns.GetHostName() + " RemoteApps Backup " + DateTime.Now.ToString("yyyy-MM-dd") + ".reg";
            DialogResult = BackupSaveFileDialog.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                string RemoteAppRegPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications";
                string BackupSavePath = BackupSaveFileDialog.FileName;

                var StartInfo = new ProcessStartInfo("reg.exe", "export \"" + RemoteAppRegPath + "\" \"" + BackupSavePath + "\" /y");
                StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(StartInfo);
            }

        }

    }
}