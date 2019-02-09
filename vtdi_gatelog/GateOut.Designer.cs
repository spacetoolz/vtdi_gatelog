namespace vtdi_gatelog
{
    partial class GateOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GateOut));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.dtpTimein = new System.Windows.Forms.DateTimePicker();
            this.tbAsset = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.tbVisit = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbAsset = new System.Windows.Forms.Label();
            this.lbVehicleModel = new System.Windows.Forms.Label();
            this.lbLicense = new System.Windows.Forms.Label();
            this.lbvisit = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbtimeOut = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(1021, 538);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(292, 114);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnedit.Location = new System.Drawing.Point(555, 538);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(292, 114);
            this.btnedit.TabIndex = 27;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(555, 77);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 38);
            this.dtpdate.TabIndex = 26;
            // 
            // dtpTimein
            // 
            this.dtpTimein.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimein.Location = new System.Drawing.Point(1068, 77);
            this.dtpTimein.Name = "dtpTimein";
            this.dtpTimein.Size = new System.Drawing.Size(200, 38);
            this.dtpTimein.TabIndex = 25;
            // 
            // tbAsset
            // 
            this.tbAsset.Location = new System.Drawing.Point(979, 378);
            this.tbAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsset.Name = "tbAsset";
            this.tbAsset.Size = new System.Drawing.Size(100, 38);
            this.tbAsset.TabIndex = 24;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(1742, 74);
            this.tbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 38);
            this.tbModel.TabIndex = 23;
            // 
            // tbLicense
            // 
            this.tbLicense.Location = new System.Drawing.Point(1458, 273);
            this.tbLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(100, 38);
            this.tbLicense.TabIndex = 22;
            // 
            // tbVisit
            // 
            this.tbVisit.Location = new System.Drawing.Point(843, 273);
            this.tbVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVisit.Name = "tbVisit";
            this.tbVisit.Size = new System.Drawing.Size(236, 38);
            this.tbVisit.TabIndex = 21;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(439, 273);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(175, 38);
            this.tbLastName.TabIndex = 20;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(121, 273);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(175, 38);
            this.tbFirstName.TabIndex = 19;
            // 
            // lbAsset
            // 
            this.lbAsset.AutoSize = true;
            this.lbAsset.BackColor = System.Drawing.Color.Transparent;
            this.lbAsset.Location = new System.Drawing.Point(730, 384);
            this.lbAsset.Name = "lbAsset";
            this.lbAsset.Size = new System.Drawing.Size(86, 32);
            this.lbAsset.TabIndex = 18;
            this.lbAsset.Text = "Asset";
            // 
            // lbVehicleModel
            // 
            this.lbVehicleModel.AutoSize = true;
            this.lbVehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.lbVehicleModel.Location = new System.Drawing.Point(1452, 77);
            this.lbVehicleModel.Name = "lbVehicleModel";
            this.lbVehicleModel.Size = new System.Drawing.Size(195, 32);
            this.lbVehicleModel.TabIndex = 17;
            this.lbVehicleModel.Text = "Vehicle Model";
            // 
            // lbLicense
            // 
            this.lbLicense.AutoSize = true;
            this.lbLicense.BackColor = System.Drawing.Color.Transparent;
            this.lbLicense.Location = new System.Drawing.Point(1324, 196);
            this.lbLicense.Name = "lbLicense";
            this.lbLicense.Size = new System.Drawing.Size(323, 32);
            this.lbLicense.TabIndex = 16;
            this.lbLicense.Text = "Vehicle License Number";
            // 
            // lbvisit
            // 
            this.lbvisit.AutoSize = true;
            this.lbvisit.BackColor = System.Drawing.Color.Transparent;
            this.lbvisit.Location = new System.Drawing.Point(837, 196);
            this.lbvisit.Name = "lbvisit";
            this.lbvisit.Size = new System.Drawing.Size(214, 32);
            this.lbvisit.TabIndex = 15;
            this.lbvisit.Text = "Purpose of Visit";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.BackColor = System.Drawing.Color.Transparent;
            this.lbLastname.Location = new System.Drawing.Point(451, 196);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(151, 32);
            this.lbLastname.TabIndex = 14;
            this.lbLastname.Text = "Last Name";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(115, 196);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(152, 32);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "First Name";
            // 
            // lbtimeOut
            // 
            this.lbtimeOut.AutoSize = true;
            this.lbtimeOut.BackColor = System.Drawing.Color.Transparent;
            this.lbtimeOut.Location = new System.Drawing.Point(888, 77);
            this.lbtimeOut.Name = "lbtimeOut";
            this.lbtimeOut.Size = new System.Drawing.Size(131, 32);
            this.lbtimeOut.TabIndex = 12;
            this.lbtimeOut.Text = "Time Out";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Location = new System.Drawing.Point(393, 77);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(75, 32);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "Date";
            // 
            // GateOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1897, 749);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.dtpTimein);
            this.Controls.Add(this.tbAsset);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.tbVisit);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbAsset);
            this.Controls.Add(this.lbVehicleModel);
            this.Controls.Add(this.lbLicense);
            this.Controls.Add(this.lbvisit);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbtimeOut);
            this.Controls.Add(this.lbDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GateOut";
            this.Text = "GateOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.DateTimePicker dtpTimein;
        private System.Windows.Forms.TextBox tbAsset;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.TextBox tbVisit;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbAsset;
        private System.Windows.Forms.Label lbVehicleModel;
        private System.Windows.Forms.Label lbLicense;
        private System.Windows.Forms.Label lbvisit;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbtimeOut;
        private System.Windows.Forms.Label lbDate;
    }
}