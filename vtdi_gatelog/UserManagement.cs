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
                    q.genderid,
                    // q.email // not present in my database
                }).ToList();

            gridviewuserinfo.DataSource = GridViewData;
        }

        private void btsaveuser_Click(object sender, EventArgs e)
        {
            

            var random = new Random();
            var fname = tbfirstName.Text;
            var lname = tbLastName.Text;
            var email = tbemail.Text;
            var username = tbusername.Text;
            var gender = Convert.ToInt32(cbgender.SelectedValue);

            var password = $"{fname[0]}{lname[0]}{random.Next(1,100)}";

            var record = new User {

                FirstName = fname,
                LastName = lname,
                genderid = gender,
                DateCreated = DateTime.Now,
                username = username,
                password = password,             
                
            };


            _dbContext.Users.Add(record);
            //_dbContext.SaveChanges();
            MessageBox.Show("Record Saved");

        }
    }
}
