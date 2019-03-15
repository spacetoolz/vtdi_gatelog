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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gateLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Logs Button Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest List Button Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Gate In Button Clicked");
            GateIn Gate = new GateIn();
            Gate.MdiParent = this;
            Gate.Show();
            
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Button Clicked");
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Button Clciked");
            UserManagement userManagement = new UserManagement();
            userManagement.MdiParent = this;
            userManagement.Show();
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling Button Clicked");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports Button Clicked");
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Reports Button Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User logs Button Clicked");
        }

        private void gateOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Out Button Clicked");
            GateOut Gate = new GateOut();
            Gate.MdiParent = this;
            Gate.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
