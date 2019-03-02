namespace vtdi_gatelog
{
    partial class GateIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GateIn));
            this.lbDate = new System.Windows.Forms.Label();
            this.lbtimeIn = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbvisit = new System.Windows.Forms.Label();
            this.lbLicense = new System.Windows.Forms.Label();
            this.lbVehicleModel = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.dtpTimein = new System.Windows.Forms.DateTimePicker();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lbAsset = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbLastname = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.vtdi_gatelogdbDataSet = new vtdi_gatelog.vtdi_gatelogdbDataSet();
            this.vtdigatelogdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purposeOfVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purposeOfVisitTableAdapter = new vtdi_gatelog.vtdi_gatelogdbDataSetTableAdapters.PurposeOfVisitTableAdapter();
            this.cbvehicletype = new System.Windows.Forms.ComboBox();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.cbItemsToDeclare = new System.Windows.Forms.ComboBox();
            this.itemsToDeclareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsToDeclareTableAdapter = new vtdi_gatelog.vtdi_gatelogdbDataSetTableAdapters.ItemsToDeclareTableAdapter();
            this.vehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTypeTableAdapter = new vtdi_gatelog.vtdi_gatelogdbDataSetTableAdapters.VehicleTypeTableAdapter();
            this.vehicleTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chbMale = new System.Windows.Forms.CheckBox();
            this.chbFemale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelogdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdigatelogdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeOfVisitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToDeclareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Location = new System.Drawing.Point(347, 98);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(75, 32);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Date";
            // 
            // lbtimeIn
            // 
            this.lbtimeIn.AutoSize = true;
            this.lbtimeIn.BackColor = System.Drawing.Color.Transparent;
            this.lbtimeIn.Location = new System.Drawing.Point(843, 98);
            this.lbtimeIn.Name = "lbtimeIn";
            this.lbtimeIn.Size = new System.Drawing.Size(108, 32);
            this.lbtimeIn.TabIndex = 2;
            this.lbtimeIn.Text = "Time In";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(69, 217);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(152, 32);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "First Name";
            // 
            // lbvisit
            // 
            this.lbvisit.AutoSize = true;
            this.lbvisit.BackColor = System.Drawing.Color.Transparent;
            this.lbvisit.Location = new System.Drawing.Point(792, 217);
            this.lbvisit.Name = "lbvisit";
            this.lbvisit.Size = new System.Drawing.Size(214, 32);
            this.lbvisit.TabIndex = 4;
            this.lbvisit.Text = "Purpose of Visit";
            // 
            // lbLicense
            // 
            this.lbLicense.AutoSize = true;
            this.lbLicense.BackColor = System.Drawing.Color.Transparent;
            this.lbLicense.Location = new System.Drawing.Point(1277, 217);
            this.lbLicense.Name = "lbLicense";
            this.lbLicense.Size = new System.Drawing.Size(323, 32);
            this.lbLicense.TabIndex = 4;
            this.lbLicense.Text = "Vehicle License Number";
            // 
            // lbVehicleModel
            // 
            this.lbVehicleModel.AutoSize = true;
            this.lbVehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.lbVehicleModel.Location = new System.Drawing.Point(1405, 98);
            this.lbVehicleModel.Name = "lbVehicleModel";
            this.lbVehicleModel.Size = new System.Drawing.Size(195, 32);
            this.lbVehicleModel.TabIndex = 4;
            this.lbVehicleModel.Text = "Vehicle Model";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(75, 293);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(175, 38);
            this.tbFirstName.TabIndex = 5;
            // 
            // dtpTimein
            // 
            this.dtpTimein.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimein.Location = new System.Drawing.Point(1021, 98);
            this.dtpTimein.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTimein.Name = "dtpTimein";
            this.dtpTimein.Size = new System.Drawing.Size(201, 38);
            this.dtpTimein.TabIndex = 9;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(509, 98);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(201, 38);
            this.dtpdate.TabIndex = 9;
            // 
            // lbAsset
            // 
            this.lbAsset.AutoSize = true;
            this.lbAsset.BackColor = System.Drawing.Color.Transparent;
            this.lbAsset.Location = new System.Drawing.Point(654, 398);
            this.lbAsset.Name = "lbAsset";
            this.lbAsset.Size = new System.Drawing.Size(228, 32);
            this.lbAsset.TabIndex = 4;
            this.lbAsset.Text = "Items To Declare";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(509, 558);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(293, 114);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(976, 558);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(293, 114);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.BackColor = System.Drawing.Color.Transparent;
            this.lbLastname.Location = new System.Drawing.Point(405, 217);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(151, 32);
            this.lbLastname.TabIndex = 4;
            this.lbLastname.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(392, 293);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(175, 38);
            this.tbLastName.TabIndex = 5;
            // 
            // cbPurpose
            // 
            this.cbPurpose.DataSource = this.purposeOfVisitBindingSource;
            this.cbPurpose.DisplayMember = "Name";
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Location = new System.Drawing.Point(800, 291);
            this.cbPurpose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(316, 39);
            this.cbPurpose.TabIndex = 11;
            this.cbPurpose.ValueMember = "Id";
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
            // purposeOfVisitBindingSource
            // 
            this.purposeOfVisitBindingSource.DataMember = "PurposeOfVisit";
            this.purposeOfVisitBindingSource.DataSource = this.vtdigatelogdbDataSetBindingSource;
            // 
            // purposeOfVisitTableAdapter
            // 
            this.purposeOfVisitTableAdapter.ClearBeforeFill = true;
            // 
            // cbvehicletype
            // 
            this.cbvehicletype.DataSource = this.vehicleTypeBindingSource1;
            this.cbvehicletype.DisplayMember = "Name";
            this.cbvehicletype.FormattingEnabled = true;
            this.cbvehicletype.Location = new System.Drawing.Point(1667, 95);
            this.cbvehicletype.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbvehicletype.Name = "cbvehicletype";
            this.cbvehicletype.Size = new System.Drawing.Size(316, 39);
            this.cbvehicletype.TabIndex = 13;
            this.cbvehicletype.ValueMember = "Id";
            // 
            // tbLicense
            // 
            this.tbLicense.Location = new System.Drawing.Point(1352, 293);
            this.tbLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(175, 38);
            this.tbLicense.TabIndex = 14;
            // 
            // cbItemsToDeclare
            // 
            this.cbItemsToDeclare.DataSource = this.itemsToDeclareBindingSource;
            this.cbItemsToDeclare.DisplayMember = "Name";
            this.cbItemsToDeclare.FormattingEnabled = true;
            this.cbItemsToDeclare.Location = new System.Drawing.Point(953, 395);
            this.cbItemsToDeclare.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbItemsToDeclare.Name = "cbItemsToDeclare";
            this.cbItemsToDeclare.Size = new System.Drawing.Size(316, 39);
            this.cbItemsToDeclare.TabIndex = 15;
            this.cbItemsToDeclare.ValueMember = "Id";
            // 
            // itemsToDeclareBindingSource
            // 
            this.itemsToDeclareBindingSource.DataMember = "ItemsToDeclare";
            this.itemsToDeclareBindingSource.DataSource = this.vtdigatelogdbDataSetBindingSource;
            // 
            // itemsToDeclareTableAdapter
            // 
            this.itemsToDeclareTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTypeBindingSource
            // 
            this.vehicleTypeBindingSource.DataMember = "VehicleType";
            this.vehicleTypeBindingSource.DataSource = this.vtdigatelogdbDataSetBindingSource;
            // 
            // vehicleTypeTableAdapter
            // 
            this.vehicleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTypeBindingSource1
            // 
            this.vehicleTypeBindingSource1.DataMember = "VehicleType";
            this.vehicleTypeBindingSource1.DataSource = this.vtdigatelogdbDataSetBindingSource;
            // 
            // chbMale
            // 
            this.chbMale.AutoSize = true;
            this.chbMale.Location = new System.Drawing.Point(1877, 307);
            this.chbMale.Name = "chbMale";
            this.chbMale.Size = new System.Drawing.Size(115, 36);
            this.chbMale.TabIndex = 16;
            this.chbMale.Text = "Male";
            this.chbMale.UseVisualStyleBackColor = true;
            // 
            // chbFemale
            // 
            this.chbFemale.AutoSize = true;
            this.chbFemale.Location = new System.Drawing.Point(1877, 365);
            this.chbFemale.Name = "chbFemale";
            this.chbFemale.Size = new System.Drawing.Size(148, 36);
            this.chbFemale.TabIndex = 17;
            this.chbFemale.Text = "Female";
            this.chbFemale.UseVisualStyleBackColor = true;
            // 
            // GateIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2431, 739);
            this.Controls.Add(this.chbFemale);
            this.Controls.Add(this.chbMale);
            this.Controls.Add(this.cbItemsToDeclare);
            this.Controls.Add(this.tbLicense);
            this.Controls.Add(this.cbvehicletype);
            this.Controls.Add(this.cbPurpose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.dtpTimein);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbAsset);
            this.Controls.Add(this.lbVehicleModel);
            this.Controls.Add(this.lbLicense);
            this.Controls.Add(this.lbvisit);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbtimeIn);
            this.Controls.Add(this.lbDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GateIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gate In Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GateIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gatelogdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdigatelogdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeOfVisitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToDeclareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbtimeIn;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbvisit;
        private System.Windows.Forms.Label lbLicense;
        private System.Windows.Forms.Label lbVehicleModel;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.DateTimePicker dtpTimein;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label lbAsset;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbPurpose;
        private vtdi_gatelogdbDataSet vtdi_gatelogdbDataSet;
        private System.Windows.Forms.BindingSource vtdigatelogdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource purposeOfVisitBindingSource;
        private vtdi_gatelogdbDataSetTableAdapters.PurposeOfVisitTableAdapter purposeOfVisitTableAdapter;
        private System.Windows.Forms.ComboBox cbvehicletype;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.ComboBox cbItemsToDeclare;
        private System.Windows.Forms.BindingSource itemsToDeclareBindingSource;
        private vtdi_gatelogdbDataSetTableAdapters.ItemsToDeclareTableAdapter itemsToDeclareTableAdapter;
        private System.Windows.Forms.BindingSource vehicleTypeBindingSource;
        private vtdi_gatelogdbDataSetTableAdapters.VehicleTypeTableAdapter vehicleTypeTableAdapter;
        private System.Windows.Forms.BindingSource vehicleTypeBindingSource1;
        private System.Windows.Forms.CheckBox chbMale;
        private System.Windows.Forms.CheckBox chbFemale;
    }
}