namespace vtdi_gatelog
{
    partial class UserManagement
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btsaveuser = new System.Windows.Forms.Button();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.lbgender = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.tbfirstName = new System.Windows.Forms.TextBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.lbUserManagement = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.gridviewuserinfo = new System.Windows.Forms.DataGridView();
            this.btsearchuser = new System.Windows.Forms.Button();
            this.vtdi_gatelogdbDataSet = new vtdi_gatelog.vtdi_gatelogdbDataSet();
            this.vtdigatelogdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewuserinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelogdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdigatelogdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btsaveuser);
            this.splitContainer1.Panel1.Controls.Add(this.cbgender);
            this.splitContainer1.Panel1.Controls.Add(this.lbgender);
            this.splitContainer1.Panel1.Controls.Add(this.tbusername);
            this.splitContainer1.Panel1.Controls.Add(this.lbUsername);
            this.splitContainer1.Panel1.Controls.Add(this.tbemail);
            this.splitContainer1.Panel1.Controls.Add(this.lbemail);
            this.splitContainer1.Panel1.Controls.Add(this.tbLastName);
            this.splitContainer1.Panel1.Controls.Add(this.lbLName);
            this.splitContainer1.Panel1.Controls.Add(this.tbfirstName);
            this.splitContainer1.Panel1.Controls.Add(this.lbFName);
            this.splitContainer1.Panel1.Controls.Add(this.lbUserManagement);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.tbsearch);
            this.splitContainer1.Panel2.Controls.Add(this.gridviewuserinfo);
            this.splitContainer1.Panel2.Controls.Add(this.btsearchuser);
            this.splitContainer1.Size = new System.Drawing.Size(1887, 1219);
            this.splitContainer1.SplitterDistance = 847;
            this.splitContainer1.TabIndex = 0;
            // 
            // btsaveuser
            // 
            this.btsaveuser.Location = new System.Drawing.Point(255, 809);
            this.btsaveuser.Name = "btsaveuser";
            this.btsaveuser.Size = new System.Drawing.Size(248, 73);
            this.btsaveuser.TabIndex = 12;
            this.btsaveuser.Text = "Save User";
            this.btsaveuser.UseVisualStyleBackColor = true;
            this.btsaveuser.Click += new System.EventHandler(this.btsaveuser_Click);
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Location = new System.Drawing.Point(362, 619);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(407, 39);
            this.cbgender.TabIndex = 11;
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Location = new System.Drawing.Point(57, 626);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(110, 32);
            this.lbgender.TabIndex = 9;
            this.lbgender.Text = "Gender";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(362, 496);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(407, 38);
            this.tbusername.TabIndex = 8;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(50, 496);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(145, 32);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(362, 376);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(407, 38);
            this.tbemail.TabIndex = 6;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(50, 382);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(198, 32);
            this.lbemail.TabIndex = 5;
            this.lbemail.Text = "Email Address";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(362, 261);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(407, 38);
            this.tbLastName.TabIndex = 4;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(50, 267);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(151, 32);
            this.lbLName.TabIndex = 3;
            this.lbLName.Text = "Last Name";
            // 
            // tbfirstName
            // 
            this.tbfirstName.Location = new System.Drawing.Point(362, 153);
            this.tbfirstName.Name = "tbfirstName";
            this.tbfirstName.Size = new System.Drawing.Size(407, 38);
            this.tbfirstName.TabIndex = 2;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(50, 160);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(152, 32);
            this.lbFName.TabIndex = 1;
            this.lbFName.Text = "First Name";
            // 
            // lbUserManagement
            // 
            this.lbUserManagement.AutoSize = true;
            this.lbUserManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbUserManagement.Location = new System.Drawing.Point(265, 56);
            this.lbUserManagement.Name = "lbUserManagement";
            this.lbUserManagement.Size = new System.Drawing.Size(247, 32);
            this.lbUserManagement.TabIndex = 0;
            this.lbUserManagement.Text = "User Management";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(590, 1101);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(248, 94);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "Delete User";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(136, 1101);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(248, 94);
            this.btUpdate.TabIndex = 16;
            this.btUpdate.Text = "Update User Information";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(90, 56);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(598, 38);
            this.tbsearch.TabIndex = 15;
            // 
            // gridviewuserinfo
            // 
            this.gridviewuserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewuserinfo.Location = new System.Drawing.Point(51, 153);
            this.gridviewuserinfo.Name = "gridviewuserinfo";
            this.gridviewuserinfo.RowTemplate.Height = 40;
            this.gridviewuserinfo.Size = new System.Drawing.Size(954, 900);
            this.gridviewuserinfo.TabIndex = 14;
            // 
            // btsearchuser
            // 
            this.btsearchuser.Location = new System.Drawing.Point(719, 35);
            this.btsearchuser.Name = "btsearchuser";
            this.btsearchuser.Size = new System.Drawing.Size(248, 73);
            this.btsearchuser.TabIndex = 13;
            this.btsearchuser.Text = "Search User";
            this.btsearchuser.UseVisualStyleBackColor = true;
            // 
            // vtdi_gatelogdbDataSet
            // 
            this.vtdi_gatelogdbDataSet.DataSetName = "vtdi_gatelogdbDataSet";
            this.vtdi_gatelogdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vtdigatelogdbDataSetBindingSource
            // 
            this.vtdigatelogdbDataSetBindingSource.DataSource = this.vtdi_gatelogdbDataSet;
            this.vtdigatelogdbDataSetBindingSource.Position = 0;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1887, 1219);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewuserinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelogdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdigatelogdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btsaveuser;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.TextBox tbfirstName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Label lbUserManagement;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.DataGridView gridviewuserinfo;
        private System.Windows.Forms.Button btsearchuser;
        private vtdi_gatelogdbDataSet vtdi_gatelogdbDataSet;
        private System.Windows.Forms.BindingSource vtdigatelogdbDataSetBindingSource;
    }
}