namespace vtdi_gatelog
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.lbtext = new System.Windows.Forms.Label();
            this.grpbxlogin = new System.Windows.Forms.GroupBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpbxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.BackColor = System.Drawing.Color.Transparent;
            this.lbtext.Font = new System.Drawing.Font("Stencil", 9.900001F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext.Location = new System.Drawing.Point(528, 31);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(129, 40);
            this.lbtext.TabIndex = 1;
            this.lbtext.Text = "Log In";
            // 
            // grpbxlogin
            // 
            this.grpbxlogin.BackColor = System.Drawing.Color.Transparent;
            this.grpbxlogin.Controls.Add(this.tbusername);
            this.grpbxlogin.Controls.Add(this.tbPassword);
            this.grpbxlogin.Controls.Add(this.lbPassword);
            this.grpbxlogin.Controls.Add(this.lbUsername);
            this.grpbxlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxlogin.Location = new System.Drawing.Point(477, 200);
            this.grpbxlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxlogin.Name = "grpbxlogin";
            this.grpbxlogin.Padding = new System.Windows.Forms.Padding(5);
            this.grpbxlogin.Size = new System.Drawing.Size(459, 162);
            this.grpbxlogin.TabIndex = 2;
            this.grpbxlogin.TabStop = false;
            this.grpbxlogin.Text = "Log In";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(245, 38);
            this.tbusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(207, 41);
            this.tbusername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(245, 95);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(207, 41);
            this.tbPassword.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(19, 103);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(155, 36);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(19, 45);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(158, 36);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(504, 427);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(763, 427);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 55);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 661);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grpbxlogin);
            this.Controls.Add(this.lbtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.grpbxlogin.ResumeLayout(false);
            this.grpbxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.GroupBox grpbxlogin;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
    }
}