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
using DSharpPlus;
using DSharpPlus.EventArgs;
using System.Threading;

namespace DiscordRPGui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private frmMain frm = new frmMain();

        private Bot bot;

        // this will hold the thread on which the bot will run
        private Task botThread { get; set; }

        // this will hold a token required to make the bot quit cleanly
        private CancellationTokenSource tokenSource { get; set; }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtToken.Text.Length > 10)
            {
                cmdLogin.Enabled = false;
                txtToken.Enabled = false;
                chkRemember.Enabled = false;
                bot = new Bot(txtToken.Text);

                bot.Client.Ready += bot_ready;
                bot.Client.ClientErrored += this.bot_ClientErrored;
                bot.Client.MessageCreated += bot_MessageReceived;

                tokenSource = new CancellationTokenSource();

                botThread = Task.Run(botThreadCallback);
            }
            else
            {
                MessageBox.Show("Please enter a valid token.", "Invalid Token", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frm.Location = Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate {
                Show();
                tokenSource.Cancel();
            };
            bot = frm.bot;

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

        private async Task botThreadCallback()
        {
            // this will start the bot
            await bot.StartAsync().ConfigureAwait(false);
            
            // here we wait indefinitely, or until the wait is
            // cancelled
            try
            {
                // the token will cancel the way once it's 
                // requested
                await Task.Delay(-1, tokenSource.Token).ConfigureAwait(false);
            }
            catch { /* ignore the exception; it's expected */ }
            
            // this will stop the bot
            await bot.StopAsync().ConfigureAwait(false);
            
            //Reenable controls
            Invoke(new Action(() =>
            {
                cmdLogin.Enabled = true;
                txtToken.Enabled = true;
                chkRemember.Enabled = true;
            }));

            // and finally, dispose of our bot stuff
            this.bot = null;
            this.tokenSource = null;
            this.botThread = null;
        }

        private Task bot_ready(ReadyEventArgs e)
        {
            //Save credentials if needed
            Settings.Default.token = txtToken.Text;
            Settings.Default.rememberpass = chkRemember.Checked;

            //Show main form and hide login form
            Invoke(new Action(frm.Show));
            Invoke(new Action(Hide));

            getChannel();

            return Task.CompletedTask;
        }

        private Task bot_MessageReceived(MessageCreateEventArgs e)
        {
            if (e.Author.Id == 170915625722576896 && e.Message.Content.Contains(bot.Client.CurrentUser.Username))
            {
                if (e.Message.Content.Contains("Stats"))
                {
                    Invoke(new Action(() =>
                    {
                        frm.lblStatsTitle.Text = e.Message.Content;
                    }));
                    
                }
                MessageBox.Show(e.Message.Content);
            }

            return Task.CompletedTask;
        }

        private async void getChannel()
        {
            //Get channel
            //DSharpPlus.Entities.DiscordUser user = await bot.Client.GetUserAsync(170915625722576896);
            frm.chn = await bot.Client.GetChannelAsync(259236936437334016);
        }

        private Task bot_ClientErrored(ClientErrorEventArgs e)
        {
            // show a message box by dispatching it to the UI thread
            MessageBox.Show(this, $"Exception in {e.EventName}: {e.Exception.ToString()}", "Unhandled exception in the bot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return Task.CompletedTask;
        }
    }
}
