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
    public partial class UserManagement : Form
    {
        private vtdi_gatelogdbEntities _dbContext; // allows database to be accessible within the load of this form
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            _dbContext = new vtdi_gatelogdbEntities();

            // run a querry to get the genders from the genders table
            //Populates the gender dropdown list
            var genders = _dbContext.Genders.ToList(); // this statement basically says pull the list of genders from the database

            //set the datasource of the genders combo box in the user management table
            cbgender.DataSource = genders;
            cbgender.DisplayMember = "Name";
            cbgender.ValueMember = "Id";

            //Grid View

            //specify the fields that we want to show
            var GridViewData = _dbContext.Users
                .Select(q => new {
                    q.FirstName,
                    q.LastName,
                    q.username,
                    //q.Email,
                    //q.genderid;
                }).ToList();

            gridviewuserinfo.DataSource = GridViewData;
        }
    }
}
