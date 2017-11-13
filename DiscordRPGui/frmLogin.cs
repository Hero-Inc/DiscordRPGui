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
            if (txtToken.Text.Length > 10)
            {
                //Save credentials if needed
                Settings.Default.token = txtToken.Text;
                Settings.Default.rememberpass = chkRemember.Checked;

                //Show main form and hide login form
                var frm = new frmMain();
                frm.Location = Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { Show(); };
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid token.", "Invalid Token", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Autofill fields
            txtToken.Text = Settings.Default.token;
            chkRemember.Checked = Settings.Default.rememberpass;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save password for next time if the user wants
            Settings.Default.token = Settings.Default.rememberpass && !string.IsNullOrWhiteSpace(Settings.Default.token) ? Settings.Default.token : ""; 
            Settings.Default.Save();
        }
    }
}
