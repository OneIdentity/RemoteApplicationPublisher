
using System;
using System.Runtime.Versioning;
using Microsoft.Win32;

namespace RemoteApplicationPublisher
{

    public class RemoteAppCollection : System.Collections.CollectionBase
    {

        public void Add(RemoteApp RemoteApp)
        {
            List.Add(RemoteApp);
        }

        public void Remove(RemoteApp RemoteApp)
        {
            List.Remove(RemoteApp);
        }
    }

    public class RemoteApp
    {
        public string Name;
        public string FullName;
        public string Path;
        public string VPath;
        public string IconPath;
        public int IconIndex = 0;
        public string CommandLine = "";
        public int CommandLineOption = 1;
        public bool TSWA = false;
        public bool UseLauncher = false;
    }

    [SupportedOSPlatform("windows")]
    public class SystemRemoteApps
    {
        private string RegistryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications";
        private RegistryKey BaseKey;
        private RegistryKey BaseKeyWrite;

        public SystemRemoteApps()
        {
            BaseKey = Registry.LocalMachine.OpenSubKey(RegistryPath);
            BaseKeyWrite = Registry.LocalMachine.OpenSubKey(RegistryPath, true);
        }

        public void Init()
        {
            string RegistryPathCV = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\";
            var cvKey = Registry.LocalMachine.OpenSubKey(RegistryPathCV, true);
            var tsKey = cvKey?.CreateSubKey("Terminal Server");
            var tsaaKey = tsKey?.CreateSubKey("TSAppAllowList");
            var appKey = tsaaKey?.CreateSubKey("Applications");
        }

        public RemoteAppCollection GetAll()
        {

            var SystemAppCollection = new RemoteAppCollection();

            foreach (string App in BaseKey.GetSubKeyNames())
            {
                var RemoteApp = GetApp(App);
                SystemAppCollection.Add(RemoteApp);
            }

            BaseKey.Close();

            return SystemAppCollection;

        }

        public RemoteApp GetApp(string Name)
        {
            var App = new RemoteApp();

            var AppKey = BaseKey.OpenSubKey(Name);
            if (AppKey != null)
            {
                App.Name = Name;
                App.FullName = Convert.ToString(AppKey.GetValue("Name", ""));
                App.Path = Convert.ToString(AppKey.GetValue("Path", ""));
                App.VPath = Convert.ToString(AppKey.GetValue("VPath", ""));
                App.CommandLine = Convert.ToString(AppKey.GetValue("RequiredCommandLine", ""));
                App.CommandLineOption = Convert.ToInt32(AppKey.GetValue("CommandLineSetting", "1"));
                App.IconPath = Convert.ToString(AppKey.GetValue("IconPath", ""));
                App.IconIndex = Convert.ToInt32(AppKey.GetValue("IconIndex", 0));
                App.TSWA = Convert.ToBoolean(AppKey.GetValue("ShowInTSWA", 0));
                App.UseLauncher = Convert.ToBoolean(AppKey.GetValue("UseLauncher", 0));
            }

            return App;
        }

        public void SaveApp(RemoteApp RemoteApp)
        {
            BaseKeyWrite.CreateSubKey(RemoteApp.Name);

            var AppKey = BaseKey.OpenSubKey(RemoteApp.Name, true);

            if (AppKey == null)
                return;

            AppKey.SetValue("Name", RemoteApp.FullName, RegistryValueKind.String);

            AppKey.SetValue("Path", RemoteApp.Path, RegistryValueKind.String);
            if (!RemoteApp.UseLauncher)
            {
                AppKey.SetValue("VPath", RemoteApp.VPath, RegistryValueKind.String);
            }
            AppKey.SetValue("RequiredCommandLine", RemoteApp.CommandLine, RegistryValueKind.String);
            AppKey.SetValue("CommandLineSetting", RemoteApp.CommandLineOption, RegistryValueKind.DWord);
            AppKey.SetValue("IconPath", RemoteApp.IconPath, RegistryValueKind.String);
            AppKey.SetValue("IconIndex", RemoteApp.IconIndex, RegistryValueKind.DWord);
            AppKey.SetValue("ShowInTSWA", RemoteApp.TSWA, RegistryValueKind.DWord);
            AppKey.SetValue("UseLauncher", RemoteApp.UseLauncher, RegistryValueKind.DWord);
        }

        public void RenameApp(string RemoteAppOldName, string RemoteAppNewName)
        {
            var SystemApps = new SystemRemoteApps();

            var App = SystemApps.GetApp(RemoteAppOldName);
            DeleteApp(RemoteAppOldName);
            App.Name = RemoteAppNewName;
            SaveApp(App);
        }

        public void DeleteApp(string Name)
        {
            BaseKeyWrite.DeleteSubKeyTree(Name);
        }
    }
}