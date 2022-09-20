using Microsoft.Win32;

namespace RemoteApplicationPublisher
{
    public partial class RemoteAppHostOptions : Form
    {
        private RemoteAppMainWindow _mainWindow;

        public RemoteAppHostOptions(RemoteAppMainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void DisconnectTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            RemoteAppFunction.ValidateSeconds(DisconnectTimeTextBox);
        }

        private void IdleTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            RemoteAppFunction.ValidateSeconds(IdleTimeTextBox);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string PolicyKeyStringMS = @"SOFTWARE\Policies\Microsoft";
            string PolicyKeyString = @"SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services";
            RegistryKey? PolicyKey = Registry.LocalMachine.OpenSubKey(PolicyKeyString, true);

            if (PolicyKey == null)
            {
                return;
            }

            // Create policy reg keys
            var PolicyKeyMS = Registry.LocalMachine.OpenSubKey(PolicyKeyStringMS, true);
            if (PolicyKeyMS != null)
            {
                var PolicyKeyWNT = PolicyKeyMS.CreateSubKey("Windows NT");
                var PolicyKeyTS = PolicyKeyWNT.CreateSubKey("Terminal Services");
            }

            if (DisableAllowListCheckBox.Checked)
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", "fDisabledAllowList", "1", RegistryValueKind.DWord);
            }
            else
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", "fDisabledAllowList", "0", RegistryValueKind.DWord);
            }

            if (AllowUnlistedRemoteProgramsCheckBox.Checked)
            {
                PolicyKey.SetValue("fAllowUnlistedRemotePrograms", 1, RegistryValueKind.DWord);
            }
            else
            {
                PolicyKey.DeleteValue("fAllowUnlistedRemotePrograms", false);
            }

            if (TimeoutDisconnectedCheckBox.Checked)
            {
                if (int.TryParse(DisconnectTimeTextBox.Text, out var disconnectionTime))
                {
                    PolicyKey.SetValue("MaxDisconnectionTime", disconnectionTime * 1000d, RegistryValueKind.DWord);
                }
            }
            else
            {
                PolicyKey.DeleteValue("MaxDisconnectionTime", false);
            }

            if (TimeoutIdleCheckBox.Checked)
            {
                if (int.TryParse(IdleTimeTextBox.Text, out var idleTime))
                {
                    PolicyKey.SetValue("MaxIdleTime", idleTime * 1000d, RegistryValueKind.DWord);
                }
            }
            else
            {
                PolicyKey.DeleteValue("MaxIdleTime", false);
            }

            if (LogoffWhenTimoutCheckBox.Checked)
            {
                PolicyKey.SetValue("fResetBroken", "1", Microsoft.Win32.RegistryValueKind.DWord);
            }
            else
            {
                PolicyKey.DeleteValue("fResetBroken", false);
            }

            Close();

        }

        public void SetValues()
        {
            string PolicyKeyString = @"SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services";
            var PolicyKey = Registry.LocalMachine.OpenSubKey(PolicyKeyString, false);

            if (PolicyKey == null)
            {
                return;
            }

            DisconnectTimeTextBox.Text = "0";
            IdleTimeTextBox.Text = "0";

            var tsAppAllowList = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", "fDisabledAllowList", "");
            if (tsAppAllowList != null && ((int)tsAppAllowList) == 1)
            {
                DisableAllowListCheckBox.Checked = true;
            }
            else
            {
                DisableAllowListCheckBox.Checked = false;
            }

            var MaxDisconnectionTime = (int?)PolicyKey.GetValue("MaxDisconnectionTime", -1);
            if (!(MaxDisconnectionTime == -1))
            {
                TimeoutDisconnectedCheckBox.Checked = true;
                DisconnectTimeTextBox.Text = (MaxDisconnectionTime / 1000d).ToString();
            }
            else
            {
                TimeoutDisconnectedCheckBox.Checked = false;
            }

            var MaxIdleTime = (int?)PolicyKey.GetValue("MaxIdleTime", -1);
            if (MaxIdleTime != null && !(MaxIdleTime == -1))
            {
                TimeoutIdleCheckBox.Checked = true;
                IdleTimeTextBox.Text = (MaxIdleTime / 1000d).ToString();
            }
            else
            {
                TimeoutIdleCheckBox.Checked = false;
            }

            var fResetBroken = (bool?)PolicyKey.GetValue("fResetBroken");
            if (fResetBroken != null && fResetBroken != default)
            {
                LogoffWhenTimoutCheckBox.Checked = true;
            }
            else
            {
                LogoffWhenTimoutCheckBox.Checked = false;
            }

            var fAllowUnlistedRemotePrograms = (bool?)PolicyKey.GetValue("fAllowUnlistedRemotePrograms");
            if (fAllowUnlistedRemotePrograms != null && fAllowUnlistedRemotePrograms != default)
            {
                AllowUnlistedRemoteProgramsCheckBox.Checked = true;
            }
            else
            {
                AllowUnlistedRemoteProgramsCheckBox.Checked = false;
            }

            if (TimeoutDisconnectedCheckBox.Checked == true)
            {
                DisconnectTimeTextBox.Enabled = true;
            }
            else
            {
                DisconnectTimeTextBox.Enabled = false;
            }

            if (TimeoutIdleCheckBox.Checked == true)
            {
                IdleTimeTextBox.Enabled = true;
            }
            else
            {
                IdleTimeTextBox.Enabled = false;
            }

        }

        private void TimeoutDisconnectedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeoutDisconnectedCheckBox.Checked == true)
            {
                DisconnectTimeTextBox.Enabled = true;
            }
            else
            {
                DisconnectTimeTextBox.Enabled = false;
            }
        }

        private void TimeoutIdleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeoutIdleCheckBox.Checked == true)
            {
                IdleTimeTextBox.Enabled = true;
            }
            else
            {
                IdleTimeTextBox.Enabled = false;
            }
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}