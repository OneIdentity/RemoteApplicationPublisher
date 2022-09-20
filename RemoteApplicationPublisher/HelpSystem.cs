using System.Collections;

namespace RemoteApplicationPublisher
{
    static class HelpSystem
    {
        public static void SetupTips(Form TheForm)
        {
            var toolTip1 = new ToolTip()
            {
                AutoPopDelay = 10000,
                InitialDelay = 500,
                ReshowDelay = 500
            };

            string HelpString;

            foreach (Control Control in TheForm.Controls)
            {
                foreach (Control SubControl in Control.Controls)
                {
                    foreach (Control SubSubControl in SubControl.Controls)
                    {
                        foreach (Control SubSubSubControl in (IEnumerable)SubSubControl.Controls)
                        {
                            HelpString = GetTipString(Control.Parent.Name, SubSubSubControl.Name);
                            if (!string.IsNullOrEmpty(HelpString))
                                toolTip1.SetToolTip((Control)SubSubSubControl, HelpString);
                        }
                        HelpString = GetTipString(Control.Parent.Name, SubSubControl.Name);
                        if (!string.IsNullOrEmpty(HelpString))
                            toolTip1.SetToolTip((Control)SubSubControl, HelpString);
                    }
                    HelpString = GetTipString(Control.Parent.Name, SubControl.Name);
                    if (!string.IsNullOrEmpty(HelpString))
                        toolTip1.SetToolTip(SubControl, HelpString);
                }
                HelpString = GetTipString(Control.Parent.Name, Control.Name);
                if (!string.IsNullOrEmpty(HelpString))
                    toolTip1.SetToolTip(Control, HelpString);
            }

        }

        private static string GetTipString(string FormName, string ControlName)
        {
            string TipString = "";

            string TipText = GetTipFile();
            var TipArray = TipText.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string TipLine in TipArray)
            {
                var TipLineArray = TipLine.Split('|');
                if ((TipLineArray[0] ?? "") == (FormName ?? "") & (TipLineArray[1] ?? "") == (ControlName ?? ""))
                    TipString = TipLineArray[2];
            }

            TipString = TipString.Replace(@"\r", "\r");
            TipString = TipString.Replace(@"\n", "\n");

            return TipString;
        }

        private static string GetTipFile()
        {
            string TipFile = "";

            if (System.IO.File.Exists("tips.txt"))
            {
                TipFile = System.IO.File.ReadAllText("tips.txt");
            }
            else
            {
                TipFile = GetBuiltInTips();
            }

            return TipFile;
        }

        private static string GetBuiltInTips()
        {
            string Tips = "";

            Tips += "RemoteAppMainWindow|CreateButton|Add a new RemoteApp.\r\n";
            Tips += "RemoteAppMainWindow|DeleteButton|Remove selected RemoteApp.\r\n";
            Tips += "RemoteAppMainWindow|EditButton|Edit properties of selected RemoteApp.\r\n";
            Tips += "RemoteAppMainWindow|CreateClientConnection|Creates a RDP file or MSI installer for the selected RemoteApp.\r\n";

            Tips += "RemoteAppEditWindow|SaveButton|Save changes and close.\r\n";
            Tips += "RemoteAppEditWindow|FTAButton|Set file type associations for this RemoteApp.\r\n";
            Tips += "RemoteAppEditWindow|CancelEditButton|Discard changes and close.\r\n";
            Tips += "RemoteAppEditWindow|BrowseIconPath|Select an icon for the RemoteApp.\r\n";
            Tips += "RemoteAppEditWindow|IconPathCopyButton|Copy the value from the \"Path\" field into the \"Icon path\" field. \r\n";
            Tips += "RemoteAppEditWindow|BrowsePath|Browse for application.\r\n";
            Tips += "RemoteAppEditWindow|IconResetButton|Reset the icon to the default for this application.\r\n";

            // IconResetButton

            Tips += "RemoteAppCreateClientConnection|RDPRadioButton|Create an RDP file.\r\n";
            Tips += "RemoteAppCreateClientConnection|MSIRadioButton|Create an MSI file.\r\n";
            Tips += "RemoteAppCreateClientConnection|EditAfterSave|Edit the RDP connection file.\r\n";
            Tips += @"RemoteAppCreateClientConnection|CreateRAWebIcon|Generate an icon for the application and any file type associations.\r\nUse this with RAWeb.\r\n";
            Tips += @"RemoteAppCreateClientConnection|FTAButton|Set file type associations for this RemoteApp.\r\nChanges here will only affect this client connection. They will not be saved.\r\n";
            Tips += "RemoteAppCreateClientConnection|DisabledFTACheckBox|Do not include file type associations in this client connection.\r\n";
            Tips += "RemoteAppCreateClientConnection|SaveButton|Save window settings for next time.\r\n";
            Tips += "RemoteAppCreateClientConnection|ResetButton|Reset window settings to defaults.\r\n";
            Tips += "RemoteAppCreateClientConnection|CancelEditButton|Close and return to the main window.\r\n";
            Tips += "RemoteAppCreateClientConnection|CreateButton|Create the client connection and choose where to save it.\r\n";
            Tips +=
                "RemoteAppCreateClientConnection|UseRDGatewayCheckBox|Use a Remote Desktop Gateway to connect to the host.\r\n";
            Tips += "RemoteAppCreateClientConnection|AttemptDirectCheckBox|Try a direct connection first, if that fails then use the Remote Desktop Gateway.\r\n";
            Tips += "RemoteAppCreateClientConnection|ShortcutTagCheckBox|Append some text to the end of each shortcut title.\r\n";
            Tips += "RemoteAppCreateClientConnection|PerMachineRadioButton|Should the shortcuts install for all users (per-machine), or only for the logged in user (per user)?\r\n";
            Tips += "RemoteAppCreateClientConnection|PerUserRadioButton|Should the shortcuts install for all users (per-machine), or only for the logged in user (per user)?\r\n";
            Tips += "RemoteAppCreateClientConnection|CheckBoxSignRDPEnabled|Digitally sign the RDP file.\r\n";
            Tips += "RemoteAppCreateClientConnection|CheckBoxCreateSignedAndUnsigned|Produce both a signed and unsigned copy of the RDP file.\r\n";

            Tips += "RemoteAppFileTypeAssociation|CreateButton|Create a new File Type Association.\r\n";
            Tips += "RemoteAppFileTypeAssociation|DeleteButton|Delete selected File Type Association.\r\n";
            Tips += "RemoteAppFileTypeAssociation|EditButton|Change icon of selected File Type Association.\r\n";
            Tips += "RemoteAppFileTypeAssociation|SetAssociationButton|Create or remove the selected File Type Association on the current system.\r\n";
            Tips += "RemoteAppFileTypeAssociation|CloseButton|Save changes and close.\r\n";

            Tips += "RemoteAppIconPicker|BrowseButton|Browse for a file that contains icons.\r\n";
            Tips += "RemoteAppIconPicker|CancelEditButton|Discard changes and close.\r\n";
            Tips += "RemoteAppIconPicker|OKButton|Choose the selected icon.\r\n";

            return Tips;
        }

    }
}