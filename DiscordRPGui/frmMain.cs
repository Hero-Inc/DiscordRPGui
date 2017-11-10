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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMine_Click(object sender, EventArgs e)
        {
            cmdMine.Enabled = false;
            pgsMine.Value = 0;
        }

        private void cmdForage_Click(object sender, EventArgs e)
        {
            cmdForage.Enabled = false;
            pgsForage.Value = 0;
        }

        private void cmdChop_Click(object sender, EventArgs e)
        {
            cmdChop.Enabled = false;
            pgsChop.Value = 0;
        }

        private void cmdFish_Click(object sender, EventArgs e)
        {
            cmdFish.Enabled = false;
            pgsFish.Value = 0;
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if(pgsMine.Value < pgsMine.Maximum)
            {
                pgsMine.Value++;
                if(pgsMine.Value == pgsMine.Maximum)
                {
                    cmdMine.Enabled = true;
                }
            }
            if (pgsForage.Value < pgsForage.Maximum)
            {
                pgsForage.Value++;
                if (pgsForage.Value == pgsForage.Maximum)
                {
                    cmdForage.Enabled = true;
                }
            }
            if (pgsChop.Value < pgsChop.Maximum)
            {
                pgsChop.Value++;
                if (pgsChop.Value == pgsChop.Maximum)
                {
                    cmdChop.Enabled = true;
                }
            }
            if (pgsFish.Value < pgsFish.Maximum)
            {
                pgsFish.Value++;
                if (pgsFish.Value == pgsFish.Maximum)
                {
                    cmdFish.Enabled = true;
                }
            }
        }

        private void cmdAllActions_Click(object sender, EventArgs e)
        {
            if(chkMine.Checked && cmdMine.Enabled)
            {
                cmdMine.Enabled = false;
                pgsMine.Value = 0;
            }
            if (chkForage.Checked && cmdForage.Enabled)
            {
                cmdForage.Enabled = false;
                pgsForage.Value = 0;
            }
            if (chkChop.Checked && cmdChop.Enabled)
            {
                cmdChop.Enabled = false;
                pgsChop.Value = 0;
            }
            if (chkFish.Checked && cmdFish.Enabled)
            {
                cmdFish.Enabled = false;
                pgsFish.Value = 0;
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            Boolean all = chkAll.Checked;
            chkMine.Checked = all;
            chkForage.Checked = all;
            chkChop.Checked = all;
            chkFish.Checked = all;
        }
    }
}
