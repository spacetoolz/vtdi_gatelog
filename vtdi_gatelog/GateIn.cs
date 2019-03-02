using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog
{
    public partial class GateIn : Form

     //private vtdi_gatelogdbDataSet ctx;
    {
        
        public GateIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)

        {
            var fname = tbFirstName.Text;
            var lname = tbLastName.Text;
            var platenum = tbLicense.Text;
            var purpose = cbPurpose.SelectedValue;
            var asset = cbItemsToDeclare.SelectedValue;
            var vehicle = cbvehicletype.SelectedValue;
            var DateTimeIn = DateTime.Now;


            MessageBox.Show("Record Submitted");
        }

        private void GateIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtdi_gatelogdbDataSet.VehicleType' table. You can move, or remove it, as needed.
            this.vehicleTypeTableAdapter.Fill(this.vtdi_gatelogdbDataSet.VehicleType);
            // TODO: This line of code loads data into the 'vtdi_gatelogdbDataSet.ItemsToDeclare' table. You can move, or remove it, as needed.
            this.itemsToDeclareTableAdapter.Fill(this.vtdi_gatelogdbDataSet.ItemsToDeclare);
            // TODO: This line of code loads data into the 'vtdi_gatelogdbDataSet.PurposeOfVisit' table. You can move, or remove it, as needed.
            this.purposeOfVisitTableAdapter.Fill(this.vtdi_gatelogdbDataSet.PurposeOfVisit);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbFirstName.Clear();
            tbLastName.Clear(); 
            //cbItemsToDeclare.Items.Clear(); Doesnt work because 
           // cbPurpose.Items.Clear();
        }
    }
}
