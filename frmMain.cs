using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using instance_controller;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;

namespace instance_controller
{
    public partial class frmMain : Form
    {
        Boolean lvDisplayingOptions = false;
        string lvExecutableName;
        const string lvCurrentVersion = "1.3";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set UI
            chkPromptOverride.Enabled = false;
            grpOpenMessage.Enabled = false;
            grpLog.Enabled = false;
            tboxArguments.Enabled = false;

            // Set initial width
            grpMoreOptions.Visible = false;
            this.Height = 140;

            // Check for write permissions
            if(!Settings.CheckForConfigPermissions(System.IO.Directory.GetCurrentDirectory().ToString()))
                MessageBox.Show("You do not have write permissions to the current directory\r\n\r\nThis may cause issues when trying to save the config file.");

            // Load INI file
            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + @"\ic-config.ini"))
            {
                // Load and execute
                IniFile SysConfig = new IniFile();
                SysConfig.Load(System.IO.Directory.GetCurrentDirectory().ToString() + @"\ic-config.ini");

                Boolean lvShowConfig = Convert.ToBoolean(SysConfig.GetKeyValue("DISPLAY CONFIG", "DisplayConfig"));
                string lvExecutable = SysConfig.GetKeyValue("BASIC OPTIONS", "Path");
                lvExecutableName = SysConfig.GetKeyValue("BASIC OPTIONS", "ExecutableName");
                Boolean lvSingleInstance = Convert.ToBoolean(SysConfig.GetKeyValue("BASIC OPTIONS", "SingleInstance"));

                Boolean lvLimitToXEnable = Convert.ToBoolean(SysConfig.GetKeyValue("MORE OPTIONS", "LimitInstances"));
                Decimal lvLimitToXValue = Convert.ToDecimal(SysConfig.GetKeyValue("MORE OPTIONS", "LimitToX").ToString());
                Boolean lvPromptOverride = Convert.ToBoolean(SysConfig.GetKeyValue("MORE OPTIONS", "PromptOverride"));
                Boolean lvOpenMessage = Convert.ToBoolean(SysConfig.GetKeyValue("MORE OPTIONS", "DisplayMessage"));
                string lvMessage = SysConfig.GetKeyValue("MORE OPTIONS", "Message");
                Boolean lvEnableLog = Convert.ToBoolean(SysConfig.GetKeyValue("MORE OPTIONS", "EnableLog"));
                string lvLogDir = SysConfig.GetKeyValue("MORE OPTIONS", "LogDir");
                Boolean lvUseArguments = Convert.ToBoolean(SysConfig.GetKeyValue("MORE OPTIONS", "UseArguments"));
                string lvArguments = SysConfig.GetKeyValue("MORE OPTIONS", "Arguments");

                SysConfig.AddSection("MORE OPTIONS").AddKey("LimitInstances").Value = chkInstanceXLimit.Checked.ToString();
                SysConfig.AddSection("MORE OPTIONS").AddKey("LimitToX").Value = numInstanceLimit.Value.ToString();

                this.Text = "IC - " + lvExecutableName;

                if (!lvShowConfig)
                {
                    Boolean lvExecute = false;
                    string lvLogEntry = "Opened";

                    // Check if limited to single instance
                    if (lvSingleInstance)
                    {
                        var lvProcesses = Process.GetProcessesByName(lvExecutableName);
                        if (lvProcesses.Length > lvLimitToXValue - 1)
                        {
                            if (lvPromptOverride)
                            {
                                if (MessageBox.Show("Another instance of this executable is running, are you sure you wish to proceed?", "IC - Already Running", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    lvExecute = true;
                                    lvLogEntry = "Opened with override";
                                }
                            }
                            else
                            {
                                MessageBox.Show("This application is limited to " + lvLimitToXValue.ToString() + " simultaneous instances", "IC - Process Already Running");
                                lvLogEntry = "Prevented - Instance limit reached";
                            }
                        }
                        else
                            lvExecute = true;
                    }
                    else
                        lvExecute = true;

                    // Pre-launch message
                    if(lvOpenMessage)
                        MessageBox.Show(lvMessage, "IC - Message",MessageBoxButtons.OK);

                    // Log execution attempt
                    if(lvEnableLog)
                    {
                        using(System.IO.StreamWriter log = new System.IO.StreamWriter(lvLogDir, true))
                        {
                            string lvUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                            log.WriteLine(DateTime.Now.ToString() + " | Process: " + lvExecutableName + " | User: " + lvUser + " | Status: " + lvLogEntry);
                        }
                    }

                    // Execute application
                    if (lvExecute)
                        if (lvUseArguments)
                            Process.Start(lvExecutable, lvArguments);
                        else
                            Process.Start(lvExecutable);

                    this.Close();
                }
                else
                {
                    // Basic Options
                    tboxExecutablePath.Text = lvExecutable;
                    chkOneInstance.Checked = lvSingleInstance;

                    // More Options
                    chkInstanceXLimit.Checked = lvLimitToXEnable;
                    numInstanceLimit.Value = lvLimitToXValue;
                    chkPromptOverride.Checked = lvPromptOverride;
                    chkOpenMessage.Checked = lvOpenMessage;
                    tboxMessage.Text = lvMessage;
                    chkEnableLog.Checked = lvEnableLog;
                    tboxLogDir.Text = lvLogDir;
                    chkLaunchWithArguments.Checked = lvUseArguments;
                    tboxArguments.Text = lvArguments;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdExecutable = new OpenFileDialog();
            ofdExecutable.Filter = "Executables (*.exe)|*.exe|All Files (*.*)|*.*";
            ofdExecutable.FilterIndex = 1;
            ofdExecutable.Multiselect = false;
            ofdExecutable.InitialDirectory = System.IO.Directory.GetCurrentDirectory().ToString();

            DialogResult dlgResult = ofdExecutable.ShowDialog();

            if(dlgResult == DialogResult.OK)
            {
                tboxExecutablePath.Text = ofdExecutable.FileName;
                lvExecutableName = ofdExecutable.SafeFileName;
            }
        }

        private void chkOneInstance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstanceXLimit.Checked) chkInstanceXLimit.Checked = !chkOneInstance.Checked;
            if (!chkOneInstance.Checked) chkPromptOverride.Checked = chkOneInstance.Checked;
            chkPromptOverride.Enabled = chkOneInstance.Checked;
            numInstanceLimit.Value = 1;
        }

        private void chkInstanceXLimit_CheckedChanged(object sender, EventArgs e)
        {
            numInstanceLimit.Enabled = chkInstanceXLimit.Checked;
            if (chkOneInstance.Checked) chkOneInstance.Checked = !chkInstanceXLimit.Checked;
            chkPromptOverride.Enabled = chkInstanceXLimit.Checked;
        }

        private void btnMoreOptions_Click(object sender, EventArgs e)
        {
            if(!lvDisplayingOptions)
            {
                lvDisplayingOptions = true;
                this.Height = 295;
                grpMoreOptions.Visible = lvDisplayingOptions;
                btnMoreOptions.Text = "Hide Options";
            }
            else 
            {
                lvDisplayingOptions = false;
                this.Height = 140;
                grpMoreOptions.Visible = lvDisplayingOptions;
                btnMoreOptions.Text = "View More Options";
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Boolean lvMessageValid = true;
            Boolean lvLogValid = true;

            // Validate options
            if (chkOpenMessage.Checked && tboxMessage.Text.Trim().Length == 0) lvMessageValid = false;
            if (chkEnableLog.Checked && tboxLogDir.Text.Trim().Length == 0) lvLogValid = false;

            if (!lvMessageValid || !lvLogValid)
                MessageBox.Show("Please ensure that both the Message and the Log directory are entered correctly.", "IC - Missing information");
            else
            {
                if (MessageBox.Show("Once you have saved this config file, the next time you open this it will launch your chosen executable with the configuration you've set here." +
                    "\r\n\r\nTo view the config again, change the 'DisplayConfig' option to TRUE in the .ini file. You will find the .ini file in the same directory as you can this utility from." +
                    "\r\n\r\nOnce you click yes, this application will close" +
                    "\r\n\r\nAre you sure you wish to create the config file?",
                    "Generate Config?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IniFile SysConfig = new IniFile();
                    // Basic Options
                    SysConfig.AddSection("BASIC OPTIONS").AddKey("Path").Value = tboxExecutablePath.Text;
                    SysConfig.AddSection("BASIC OPTIONS").AddKey("SingleInstance").Value = chkOneInstance.Checked.ToString();
                    SysConfig.AddSection("BASIC OPTIONS").AddKey("ExecutableName").Value = lvExecutableName.Replace(".exe", "");

                    // More Options
                    SysConfig.AddSection("MORE OPTIONS").AddKey("LimitInstances").Value = chkInstanceXLimit.Checked.ToString();
                    SysConfig.AddSection("MORE OPTIONS").AddKey("LimitToX").Value = numInstanceLimit.Value.ToString();
                    SysConfig.AddSection("MORE OPTIONS").AddKey("PromptOverride").Value = chkPromptOverride.Checked.ToString();
                    SysConfig.AddSection("MORE OPTIONS").AddKey("DisplayMessage").Value = chkOpenMessage.Checked.ToString();
                    SysConfig.AddSection("MORE OPTIONS").AddKey("Message").Value = tboxMessage.Text;
                    SysConfig.AddSection("MORE OPTIONS").AddKey("EnableLog").Value = chkEnableLog.Checked.ToString();
                    SysConfig.AddSection("MORE OPTIONS").AddKey("LogDir").Value = tboxLogDir.Text;
                    SysConfig.AddSection("MORE OPTIONS").AddKey("UseArguments").Value = chkLaunchWithArguments.Checked.ToString();
                    SysConfig.AddSection("MORE OPTIONS").AddKey("Arguments").Value = tboxArguments.Text;

                    SysConfig.AddSection("DISPLAY CONFIG").AddKey("DisplayConfig").Value = "false";

                    // Save Config
                    SysConfig.Save(System.IO.Directory.GetCurrentDirectory().ToString() + @"\ic-config.ini");

                    this.Close();
                }
            }
        }

        private void chkOpenMessage_CheckedChanged(object sender, EventArgs e)
        {
            grpOpenMessage.Enabled = chkOpenMessage.Checked;
            if (!chkOpenMessage.Checked) tboxMessage.Text = "";
        }

        private void chkLogOpening_CheckedChanged(object sender, EventArgs e)
        {
            grpLog.Enabled = chkEnableLog.Checked;
            if (!chkEnableLog.Checked) tboxLogDir.Text = "";
        }

        private void btnLogDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdLogDir = new FolderBrowserDialog();

            if (DialogResult.OK == fbdLogDir.ShowDialog())
                tboxLogDir.Text = fbdLogDir.SelectedPath.ToString() + @"\ic-" + lvExecutableName + ".log";
        }

        private void chkLaunchWithArguments_CheckedChanged(object sender, EventArgs e)
        {
            tboxArguments.Enabled = chkLaunchWithArguments.Checked;
            if (!chkLaunchWithArguments.Checked) { tboxArguments.Text = ""; }
        }

        private void supportForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://dkoz.co.uk/forums");
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://dkoz.co.uk/instance-controller-docs");
        }

        private void tslblCheckForUpdates_Click(object sender, EventArgs e)
        {
            DialogResult CheckDownload = MessageBox.Show("This will check my website for the latest version, no other information apart from IC version numbers are transmitted, are you sure you wish to continue?", "IC - Update", MessageBoxButtons.YesNo);

            if (CheckDownload == DialogResult.Yes)
            {
                tslblCheckForUpdates.Enabled = false;
                tslblCheckForUpdates.Text = "Checking for Updates";
                System.Net.WebClient wc = new System.Net.WebClient();
                byte[] tmpVersion = wc.DownloadData("http://dkoz.co.uk/version.php?application=instanceController");
                string lvVersion = System.Text.Encoding.UTF8.GetString(tmpVersion);

                String regex = @"[[0-9]{1,9}.[0-9]{1,9}]";
                Match coll = Regex.Match(lvVersion, regex);
                string result = coll.ToString();
                string lvLatestVersion = result.Replace("[", "");
                lvLatestVersion = lvLatestVersion.Replace("]", "");
            
                if (Convert.ToDouble(lvCurrentVersion) < Convert.ToDouble(lvLatestVersion))
                {
                    DialogResult DownloadLatest = MessageBox.Show("A new version was found ("+lvLatestVersion+"), would you like to download it?", "Download Update?", MessageBoxButtons.YesNo);
                    if(DownloadLatest == DialogResult.Yes)
                        Process.Start("http://dkoz.co.uk/blog/download/instance-controller/");
                }
                else
                    MessageBox.Show("You are already using the latest version - " + lvCurrentVersion, "IC - Update", MessageBoxButtons.OK);
            
                tslblCheckForUpdates.Enabled = true;
                tslblCheckForUpdates.Text = "Check for Updates";
            }
        }
    }
}