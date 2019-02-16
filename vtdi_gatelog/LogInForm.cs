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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            var password = tbPassword.Text;

            if (username != "admin" || password != "pass")
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
                {
                MessageBox.Show($"Welcome {username}");
                var parent = (Form1)this.MdiParent;
                Close();
                }

        }
    }
}
