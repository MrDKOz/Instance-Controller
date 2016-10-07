namespace instance_controller
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpBasicOptions = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnMoreOptions = new System.Windows.Forms.Button();
            this.chkPromptOverride = new System.Windows.Forms.CheckBox();
            this.chkOneInstance = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tboxExecutablePath = new System.Windows.Forms.TextBox();
            this.lblExecutablePath = new System.Windows.Forms.Label();
            this.grpMoreOptions = new System.Windows.Forms.GroupBox();
            this.tboxArguments = new System.Windows.Forms.TextBox();
            this.chkLaunchWithArguments = new System.Windows.Forms.CheckBox();
            this.chkOpenMessage = new System.Windows.Forms.CheckBox();
            this.chkEnableLog = new System.Windows.Forms.CheckBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogDir = new System.Windows.Forms.Button();
            this.tboxLogDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOpenMessage = new System.Windows.Forms.GroupBox();
            this.tboxMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslnkHomepage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblCheckForUpdates = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.supportForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkInstanceXLimit = new System.Windows.Forms.CheckBox();
            this.numInstanceLimit = new System.Windows.Forms.NumericUpDown();
            this.grpBasicOptions.SuspendLayout();
            this.grpMoreOptions.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.grpOpenMessage.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInstanceLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBasicOptions
            // 
            this.grpBasicOptions.Controls.Add(this.btnApply);
            this.grpBasicOptions.Controls.Add(this.btnMoreOptions);
            this.grpBasicOptions.Controls.Add(this.chkOneInstance);
            this.grpBasicOptions.Controls.Add(this.btnBrowse);
            this.grpBasicOptions.Controls.Add(this.tboxExecutablePath);
            this.grpBasicOptions.Controls.Add(this.lblExecutablePath);
            this.grpBasicOptions.Location = new System.Drawing.Point(6, 3);
            this.grpBasicOptions.Name = "grpBasicOptions";
            this.grpBasicOptions.Size = new System.Drawing.Size(458, 70);
            this.grpBasicOptions.TabIndex = 0;
            this.grpBasicOptions.TabStop = false;
            this.grpBasicOptions.Text = "Basic Options";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(398, 43);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(54, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnMoreOptions
            // 
            this.btnMoreOptions.Location = new System.Drawing.Point(287, 43);
            this.btnMoreOptions.Name = "btnMoreOptions";
            this.btnMoreOptions.Size = new System.Drawing.Size(105, 23);
            this.btnMoreOptions.TabIndex = 5;
            this.btnMoreOptions.Text = "View More Options";
            this.btnMoreOptions.UseVisualStyleBackColor = true;
            this.btnMoreOptions.Click += new System.EventHandler(this.btnMoreOptions_Click);
            // 
            // chkPromptOverride
            // 
            this.chkPromptOverride.AutoSize = true;
            this.chkPromptOverride.Location = new System.Drawing.Point(236, 19);
            this.chkPromptOverride.Name = "chkPromptOverride";
            this.chkPromptOverride.Size = new System.Drawing.Size(102, 17);
            this.chkPromptOverride.TabIndex = 4;
            this.chkPromptOverride.Text = "Prompt Override";
            this.chkPromptOverride.UseVisualStyleBackColor = true;
            // 
            // chkOneInstance
            // 
            this.chkOneInstance.AutoSize = true;
            this.chkOneInstance.Location = new System.Drawing.Point(14, 47);
            this.chkOneInstance.Name = "chkOneInstance";
            this.chkOneInstance.Size = new System.Drawing.Size(142, 17);
            this.chkOneInstance.TabIndex = 3;
            this.chkOneInstance.Text = "Allow Only One Instance";
            this.chkOneInstance.UseVisualStyleBackColor = true;
            this.chkOneInstance.CheckedChanged += new System.EventHandler(this.chkOneInstance_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(428, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tboxExecutablePath
            // 
            this.tboxExecutablePath.Location = new System.Drawing.Point(102, 18);
            this.tboxExecutablePath.Name = "tboxExecutablePath";
            this.tboxExecutablePath.Size = new System.Drawing.Size(326, 20);
            this.tboxExecutablePath.TabIndex = 1;
            // 
            // lblExecutablePath
            // 
            this.lblExecutablePath.AutoSize = true;
            this.lblExecutablePath.Location = new System.Drawing.Point(11, 21);
            this.lblExecutablePath.Name = "lblExecutablePath";
            this.lblExecutablePath.Size = new System.Drawing.Size(85, 13);
            this.lblExecutablePath.TabIndex = 0;
            this.lblExecutablePath.Text = "Exectuable Path";
            // 
            // grpMoreOptions
            // 
            this.grpMoreOptions.Controls.Add(this.numInstanceLimit);
            this.grpMoreOptions.Controls.Add(this.chkInstanceXLimit);
            this.grpMoreOptions.Controls.Add(this.chkPromptOverride);
            this.grpMoreOptions.Controls.Add(this.tboxArguments);
            this.grpMoreOptions.Controls.Add(this.chkLaunchWithArguments);
            this.grpMoreOptions.Controls.Add(this.chkOpenMessage);
            this.grpMoreOptions.Controls.Add(this.chkEnableLog);
            this.grpMoreOptions.Controls.Add(this.grpLog);
            this.grpMoreOptions.Controls.Add(this.grpOpenMessage);
            this.grpMoreOptions.Location = new System.Drawing.Point(6, 79);
            this.grpMoreOptions.Name = "grpMoreOptions";
            this.grpMoreOptions.Size = new System.Drawing.Size(458, 151);
            this.grpMoreOptions.TabIndex = 1;
            this.grpMoreOptions.TabStop = false;
            this.grpMoreOptions.Text = "More Options";
            // 
            // tboxArguments
            // 
            this.tboxArguments.Location = new System.Drawing.Point(145, 125);
            this.tboxArguments.Name = "tboxArguments";
            this.tboxArguments.Size = new System.Drawing.Size(297, 20);
            this.tboxArguments.TabIndex = 4;
            // 
            // chkLaunchWithArguments
            // 
            this.chkLaunchWithArguments.AutoSize = true;
            this.chkLaunchWithArguments.Location = new System.Drawing.Point(14, 127);
            this.chkLaunchWithArguments.Name = "chkLaunchWithArguments";
            this.chkLaunchWithArguments.Size = new System.Drawing.Size(136, 17);
            this.chkLaunchWithArguments.TabIndex = 3;
            this.chkLaunchWithArguments.Text = "Launch with arguments";
            this.chkLaunchWithArguments.UseVisualStyleBackColor = true;
            this.chkLaunchWithArguments.CheckedChanged += new System.EventHandler(this.chkLaunchWithArguments_CheckedChanged);
            // 
            // chkOpenMessage
            // 
            this.chkOpenMessage.AutoSize = true;
            this.chkOpenMessage.Location = new System.Drawing.Point(14, 42);
            this.chkOpenMessage.Name = "chkOpenMessage";
            this.chkOpenMessage.Size = new System.Drawing.Size(201, 17);
            this.chkOpenMessage.TabIndex = 0;
            this.chkOpenMessage.Text = "Display Message (before app launch)";
            this.chkOpenMessage.UseVisualStyleBackColor = true;
            this.chkOpenMessage.CheckedChanged += new System.EventHandler(this.chkOpenMessage_CheckedChanged);
            // 
            // chkEnableLog
            // 
            this.chkEnableLog.AutoSize = true;
            this.chkEnableLog.Location = new System.Drawing.Point(236, 42);
            this.chkEnableLog.Name = "chkEnableLog";
            this.chkEnableLog.Size = new System.Drawing.Size(94, 17);
            this.chkEnableLog.TabIndex = 0;
            this.chkEnableLog.Text = "Log Execution";
            this.chkEnableLog.UseVisualStyleBackColor = true;
            this.chkEnableLog.CheckedChanged += new System.EventHandler(this.chkLogOpening_CheckedChanged);
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.label2);
            this.grpLog.Controls.Add(this.btnLogDir);
            this.grpLog.Controls.Add(this.tboxLogDir);
            this.grpLog.Controls.Add(this.label1);
            this.grpLog.Location = new System.Drawing.Point(236, 57);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(206, 62);
            this.grpLog.TabIndex = 1;
            this.grpLog.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(will be saved as a .log file)";
            // 
            // btnLogDir
            // 
            this.btnLogDir.Location = new System.Drawing.Point(176, 22);
            this.btnLogDir.Name = "btnLogDir";
            this.btnLogDir.Size = new System.Drawing.Size(24, 22);
            this.btnLogDir.TabIndex = 3;
            this.btnLogDir.Text = "...";
            this.btnLogDir.UseVisualStyleBackColor = true;
            this.btnLogDir.Click += new System.EventHandler(this.btnLogDir_Click);
            // 
            // tboxLogDir
            // 
            this.tboxLogDir.Location = new System.Drawing.Point(9, 23);
            this.tboxLogDir.Name = "tboxLogDir";
            this.tboxLogDir.Size = new System.Drawing.Size(167, 20);
            this.tboxLogDir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save log to:";
            // 
            // grpOpenMessage
            // 
            this.grpOpenMessage.Controls.Add(this.tboxMessage);
            this.grpOpenMessage.Controls.Add(this.lblMessage);
            this.grpOpenMessage.Location = new System.Drawing.Point(14, 57);
            this.grpOpenMessage.Name = "grpOpenMessage";
            this.grpOpenMessage.Size = new System.Drawing.Size(215, 62);
            this.grpOpenMessage.TabIndex = 0;
            this.grpOpenMessage.TabStop = false;
            // 
            // tboxMessage
            // 
            this.tboxMessage.Location = new System.Drawing.Point(9, 24);
            this.tboxMessage.Name = "tboxMessage";
            this.tboxMessage.Size = new System.Drawing.Size(200, 20);
            this.tboxMessage.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslnkHomepage,
            this.tsSpring,
            this.tslblCheckForUpdates,
            this.toolStripDropDownButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 234);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(469, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // tslnkHomepage
            // 
            this.tslnkHomepage.Name = "tslnkHomepage";
            this.tslnkHomepage.Size = new System.Drawing.Size(107, 17);
            this.tslnkHomepage.Text = "daniel@dkoz.co.uk";
            // 
            // tsSpring
            // 
            this.tsSpring.Name = "tsSpring";
            this.tsSpring.Size = new System.Drawing.Size(196, 17);
            this.tsSpring.Spring = true;
            // 
            // tslblCheckForUpdates
            // 
            this.tslblCheckForUpdates.Image = ((System.Drawing.Image)(resources.GetObject("tslblCheckForUpdates.Image")));
            this.tslblCheckForUpdates.IsLink = true;
            this.tslblCheckForUpdates.Name = "tslblCheckForUpdates";
            this.tslblCheckForUpdates.Size = new System.Drawing.Size(122, 17);
            this.tslblCheckForUpdates.Text = "Check For Updates";
            this.tslblCheckForUpdates.Click += new System.EventHandler(this.tslblCheckForUpdates_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportForumToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::instance_controller.Properties.Resources.help;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // supportForumToolStripMenuItem
            // 
            this.supportForumToolStripMenuItem.Name = "supportForumToolStripMenuItem";
            this.supportForumToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.supportForumToolStripMenuItem.Text = "Support Forum";
            this.supportForumToolStripMenuItem.Click += new System.EventHandler(this.supportForumToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // chkInstanceXLimit
            // 
            this.chkInstanceXLimit.AutoSize = true;
            this.chkInstanceXLimit.Location = new System.Drawing.Point(14, 19);
            this.chkInstanceXLimit.Name = "chkInstanceXLimit";
            this.chkInstanceXLimit.Size = new System.Drawing.Size(161, 17);
            this.chkInstanceXLimit.TabIndex = 5;
            this.chkInstanceXLimit.Text = "Limit to                   instances";
            this.chkInstanceXLimit.UseVisualStyleBackColor = true;
            this.chkInstanceXLimit.CheckedChanged += new System.EventHandler(this.chkInstanceXLimit_CheckedChanged);
            // 
            // numInstanceLimit
            // 
            this.numInstanceLimit.Enabled = false;
            this.numInstanceLimit.Location = new System.Drawing.Point(69, 18);
            this.numInstanceLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numInstanceLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInstanceLimit.Name = "numInstanceLimit";
            this.numInstanceLimit.Size = new System.Drawing.Size(50, 20);
            this.numInstanceLimit.TabIndex = 6;
            this.numInstanceLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 256);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpMoreOptions);
            this.Controls.Add(this.grpBasicOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "IC: New Config";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBasicOptions.ResumeLayout(false);
            this.grpBasicOptions.PerformLayout();
            this.grpMoreOptions.ResumeLayout(false);
            this.grpMoreOptions.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.grpOpenMessage.ResumeLayout(false);
            this.grpOpenMessage.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInstanceLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBasicOptions;
        private System.Windows.Forms.Button btnMoreOptions;
        private System.Windows.Forms.CheckBox chkPromptOverride;
        private System.Windows.Forms.CheckBox chkOneInstance;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tboxExecutablePath;
        private System.Windows.Forms.Label lblExecutablePath;
        private System.Windows.Forms.GroupBox grpMoreOptions;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslnkHomepage;
        private System.Windows.Forms.ToolStripStatusLabel tsSpring;
        private System.Windows.Forms.GroupBox grpOpenMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkOpenMessage;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogDir;
        private System.Windows.Forms.TextBox tboxLogDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnableLog;
        private System.Windows.Forms.TextBox tboxArguments;
        private System.Windows.Forms.CheckBox chkLaunchWithArguments;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tboxMessage;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem supportForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tslblCheckForUpdates;
        private System.Windows.Forms.NumericUpDown numInstanceLimit;
        private System.Windows.Forms.CheckBox chkInstanceXLimit;
    }
}

