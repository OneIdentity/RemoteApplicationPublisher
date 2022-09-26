using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace RemoteApplicationPublisher
{
    public partial class RemoteAppMainWindow : Form
    {
        public RemoteAppMainWindow()
        {
            InitializeComponent();
            AdminRelauncher();
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
            AppList.Clear();

            var systemApps = new SystemRemoteApps();
            var apps = systemApps.GetAll();

            foreach (RemoteApp app in apps)
            {
                SmallIcons.Images.RemoveByKey(app.Name);
                var iconBitmap = RemoteAppFunction.GetAppBitmap(app.Name);
                var appItem = new ListViewItem(app.Name);
                appItem.ToolTipText = app.FullName;
                appItem.ImageIndex = 0;
                SmallIcons.Images.Add(app.Name, iconBitmap);
                appItem.ImageKey = app.Name;
                AppList.Items.Add(appItem);
            }

            if (apps.Count == 0)
            {
                NoAppsLabel.Visible = true;
            }
            else
            {
                NoAppsLabel.Visible = false;
            }

            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void AppList_DoubleClick(object sender, EventArgs e)
        {
            if (AppList.SelectedItems.Count == 1)
            {
                EditRemoteApp(AppList.SelectedItems[0].Text);
            }
        }

        private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AppList.SelectedItems.Count == 1)
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (AppList.SelectedItems.Count == 1)
            {
                EditRemoteApp(AppList.SelectedItems[0].Text);
            }
        }

        private void EditRemoteApp(string AppName)
        {
            var sra = new SystemRemoteApps();
            var remoteAppEditWindow = new RemoteAppEditWindow(this);
            remoteAppEditWindow.EditRemoteApp(sra.GetApp(AppName));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteRemoteApp(AppList.SelectedItems[0].Text);
            ReloadApps();
        }

        private void DeleteRemoteApp(string AppName)
        {
            if (MessageBox.Show("Are you sure you want to remove " + AppName + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sra = new SystemRemoteApps();
                sra.DeleteApp(AppName);
            }
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

        private void AdminRelauncher()
        {
            if (!IsRunAsAdmin())
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Assembly.GetEntryAssembly().Location.Replace(".dll", ".exe");;
        
                proc.Verb = "runas";
        
                try
                {
                    Process.Start(proc);
                    Environment.Exit(0);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("This program must be run as an administrator! \n\n" + ex.ToString());
                }
            }
        }
        
        private bool IsRunAsAdmin()
        {
            try
            {
                WindowsIdentity id = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(id);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}