using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSharpPlus;
using DSharpPlus.EventArgs;

namespace DiscordRPGui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        public Bot bot { get; set; }

        public DSharpPlus.Entities.DiscordChannel chn;

        private void btnLogout_Click(object sender, EventArgs e) => Close();

        private void cmdMine_Click(object sender, EventArgs e)
        {
            sendMessage(">mine");
            cmdMine.Enabled = false;
            pgsMine.Value = 0;
        }

        private void cmdForage_Click(object sender, EventArgs e)
        {
            sendMessage(">Forage");
            cmdForage.Enabled = false;
            pgsForage.Value = 0;
        }

        private void cmdChop_Click(object sender, EventArgs e)
        {
            sendMessage(">Chop");
            cmdChop.Enabled = false;
            pgsChop.Value = 0;
        }

        private void cmdFish_Click(object sender, EventArgs e)
        {
            sendMessage(">Fish");
            cmdFish.Enabled = false;
            pgsFish.Value = 0;
        }

        private void cmdAdventure_Click(object sender, EventArgs e)
        {
            sendMessage(">adv");
            cmdAdventure.Enabled = false;
            pgsAdv.Value = 0;
        }

        private void cmdHeal_Click(object sender, EventArgs e)
        {
            sendMessage(">heal");
            pgsHeal.Value = 0;
        }

        private void btnStatsRefresh_Click(object sender, EventArgs e)
        {
            sendMessage(">stats");
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            ProgressBar[] bars = { pgsMine, pgsForage, pgsChop, pgsFish, pgsAdv, pgsHeal };
            Button[] buttons = { cmdMine, cmdForage, cmdChop, cmdFish, cmdAdventure, cmdHeal };
            for (int i = 0; i < bars.Length; i++)
            {
                if (bars[i].Value < bars[i].Maximum)
                {
                    bars[i].Value++;
                    if (bars[i].Value == bars[i].Maximum)
                    {
                        buttons[i].Enabled = true;
                    }
                }
            }
        }

        private void cmdAllActions_Click(object sender, EventArgs e)
        {
            if(chkMine.Checked && cmdMine.Enabled)
            {
                cmdMine.PerformClick();
            }
            if (chkForage.Checked && cmdForage.Enabled)
            {
                cmdForage.PerformClick();
            }
            if (chkChop.Checked && cmdChop.Enabled)
            {
                cmdChop.PerformClick();
            }
            if (chkFish.Checked && cmdFish.Enabled)
            {
                cmdFish.PerformClick();
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void sendMessage(string message)
        {
            _ = Task.Run(() => BotSendMessageCallback(message));
        }

        private Task BotSendMessageCallback(string text)
            => chn.SendMessageAsync(text);

        
    }
}
