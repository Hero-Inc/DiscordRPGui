using DiscordRPGui.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordRPGui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //Save credentials if needed
            Settings.Default.username = txtUsername.Text;
            Settings.Default.rememberpass = chkRemember.Checked;
            Settings.Default.Save();
            Settings.Default.password = txtPassword.Text;

            //Show main form and hide login form
            var frm = new frmMain();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.lblLoggedInAs.Text = "Currently logged in as " + txtUsername.Text;
            frm.Text = txtUsername.Text + "'s Adventure";
            frm.lblStatsTitle.Text = txtUsername.Text + "'s Stats";
            frm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Autofill fields
            txtUsername.Text = Settings.Default.username;
            txtPassword.Text = Settings.Default.password;
            chkRemember.Checked = Settings.Default.rememberpass;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save password for next time if the user wants
            Settings.Default.password = Settings.Default.rememberpass ? Settings.Default.password : ""; 
            Settings.Default.Save();
        }
    }
}
