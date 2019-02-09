namespace vtdi_gatelog
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.gateLogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 52);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.gateReportsToolStripMenuItem,
            this.userLogsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(132, 48);
            this.helpToolStripMenuItem.Text = "Reports";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(301, 6);
            // 
            // gateReportsToolStripMenuItem
            // 
            this.gateReportsToolStripMenuItem.Name = "gateReportsToolStripMenuItem";
            this.gateReportsToolStripMenuItem.Size = new System.Drawing.Size(304, 46);
            this.gateReportsToolStripMenuItem.Text = "Gate Reports";
            this.gateReportsToolStripMenuItem.Click += new System.EventHandler(this.gateReportsToolStripMenuItem_Click);
            // 
            // userLogsToolStripMenuItem
            // 
            this.userLogsToolStripMenuItem.Name = "userLogsToolStripMenuItem";
            this.userLogsToolStripMenuItem.Size = new System.Drawing.Size(304, 46);
            this.userLogsToolStripMenuItem.Text = "User Logs";
            this.userLogsToolStripMenuItem.Click += new System.EventHandler(this.userLogsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.schedulingToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(103, 48);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(377, 46);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(377, 46);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(377, 46);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            this.schedulingToolStripMenuItem.Click += new System.EventHandler(this.schedulingToolStripMenuItem_Click);
            // 
            // gateLogsToolStripMenuItem
            // 
            this.gateLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestListToolStripMenuItem,
            this.gateInOutToolStripMenuItem,
            this.gateOutToolStripMenuItem});
            this.gateLogsToolStripMenuItem.Name = "gateLogsToolStripMenuItem";
            this.gateLogsToolStripMenuItem.Size = new System.Drawing.Size(163, 48);
            this.gateLogsToolStripMenuItem.Text = "Gate Logs";
            this.gateLogsToolStripMenuItem.Click += new System.EventHandler(this.gateLogsToolStripMenuItem_Click);
            // 
            // guestListToolStripMenuItem
            // 
            this.guestListToolStripMenuItem.Name = "guestListToolStripMenuItem";
            this.guestListToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.guestListToolStripMenuItem.Text = "Guest List";
            this.guestListToolStripMenuItem.Click += new System.EventHandler(this.guestListToolStripMenuItem_Click);
            // 
            // gateInOutToolStripMenuItem
            // 
            this.gateInOutToolStripMenuItem.Name = "gateInOutToolStripMenuItem";
            this.gateInOutToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.gateInOutToolStripMenuItem.Text = "Gate In";
            this.gateInOutToolStripMenuItem.Click += new System.EventHandler(this.gateInOutToolStripMenuItem_Click);
            // 
            // gateOutToolStripMenuItem
            // 
            this.gateOutToolStripMenuItem.Name = "gateOutToolStripMenuItem";
            this.gateOutToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.gateOutToolStripMenuItem.Text = "Gate Out";
            this.gateOutToolStripMenuItem.Click += new System.EventHandler(this.gateOutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VTDI Gate Log Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem gateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateOutToolStripMenuItem;
    }
}

