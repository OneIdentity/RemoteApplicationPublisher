﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RemoteApplicationPublisher
{

    [SupportedOSPlatform("windows")]
    static class RemoteAppFunction
    {

        public static void ValidateInteger(TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                textBox.Text = string.Empty;
                textBox.Select(0, 0);
            }
        }

        public static void ValidatePort(TextBox textBox)
        {
            var result = int.TryParse(textBox.Text, out var port);
            if (!result)
            {
                textBox.Text = string.Empty;
                textBox.Select(0, 0);
            }
            if (port > 65535d)
            {
                textBox.Text = "65535";
            }

            textBox.Text = port.ToString();
            textBox.Select(textBox.Text.Length, 0);
        }

        public static void ValidateSeconds(NumericUpDown counter)
        {
            var seconds = Convert.ToInt32(counter.Value);
            if (seconds > 2147483d)
            {
                counter.Value = 2147483;
            }

            counter.Value = seconds;
        }

        public static void ValidateAppName(TextBox textBox)
        {
            ValidateTextBoxR(textBox, @"[^\p{L}0-9\-_"" ""()]");
        }

        private static void ValidateTextBoxR(TextBox textBox, string regex)
        {
            var rx = new Regex(regex);
            if (rx.IsMatch(textBox.Text))
            {
                textBox.Text = rx.Replace(textBox.Text, "");
            }
        }

        public static string FixShortAppName(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var rx = new Regex(@"[^\p{L}0-9\-_"" ""]");
                if (rx.IsMatch(text))
                {
                    text = rx.Replace(text, "");
                }
            }
            text = text.Trim();
            return text;
        }

        public static void ValidateDNSname(TextBox textBox)
        {
            // pattern matches any character that is NOT A-Z (allows upper and lower case alphabets)
            var rx = new Regex(@"[^\p{L}LlUu0-9\-\._:]");
            if (rx.IsMatch(textBox.Text))
            {
                textBox.Text = rx.Replace(textBox.Text, "");
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        public static void ValidateFileType(TextBox textBox)
        {
            // pattern matches any character that is NOT A-Z (allows upper and lower case alphabets)
            var rx = new Regex(@"[^\p{L}0-9\-_\!\@\#\$\%\^\&\(\)\{\}\[\]\+\=\;\,\']");
            if (rx.IsMatch(textBox.Text))
            {
                textBox.Text = rx.Replace(textBox.Text, "");
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        public static Bitmap? GetAppBitmap(string RemoteAppShortName)
        {
            string appKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications" + @"\" + RemoteAppShortName;
            var regKey = Registry.LocalMachine.OpenSubKey(appKey, true);
            var icon = ReturnIcon("")?.ToBitmap();
            if (regKey != null)
            {
                var IconPath = (string?)regKey.GetValue("IconPath", "");
                icon = ReturnIcon(IconPath)?.ToBitmap();
            }
            return icon;
        }

        public static Icon? ReturnIcon(string? path)
        {
            if (path != null && File.Exists(path))
            {
                var ico = Icon.ExtractAssociatedIcon(path);
                return ico;
            }

            return Icon.ExtractAssociatedIcon(Environment.ProcessPath ?? "");
        }

        public static string GetSysDir()
        {
            return Environment.SystemDirectory.ToString();
        }

        public static string GetEXETitle(string exePath)
        {
            var pname = FileVersionInfo.GetVersionInfo(exePath).FileDescription;
            if (string.IsNullOrEmpty(pname))
                pname = new FileInfo(exePath).Name.Substring(0, new FileInfo(exePath).Name.Length - 4);

            return pname;
        }

    }
}