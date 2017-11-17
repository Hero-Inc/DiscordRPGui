using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSharpPlus.EventArgs;
using DSharpPlus.Entities;
using DiscordRPGui.Properties;
using System.Linq;

namespace DiscordRPGui
{
    public partial class frmCombined : Form
    {
        public frmCombined() => InitializeComponent();
        private Bot bot { get; set; }
        private Task botThread { get; set; }
        private CancellationTokenSource tokenSource { get; set; }
        private RPGAction[] actions;

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            foreach (var action in actions)
            {
                if (action.progressBar.Value < action.progressBar.Maximum)
                {
                    action.progressBar.Increment(1);
                    if (action.progressBar.Value == action.progressBar.Maximum)
                    {
                        action.button.Enabled = true;
                    }
                }
            }
            if (pgsAdv.Value < pgsAdv.Maximum)
            {
                pgsAdv.Increment(1);
                if (pgsAdv.Value == pgsAdv.Maximum)
                {
                    cmdAdv.Enabled = true;
                }
            }
            if (pgsHeal.Value < pgsHeal.Maximum)
            {
                pgsHeal.Increment(1);
                if (pgsHeal.Value == pgsHeal.Maximum)
                {
                    cmdHeal.Enabled = true;
                }
            }
        }

        private void frmCombined_Load(object sender, EventArgs e)
        {
            //Autofill fields
            txtToken.Text = Settings.Default.token;
            chkRemember.Checked = Settings.Default.rememberToken;
            txtChannel.Text = Convert.ToString(Settings.Default.channel);

            //Block other tabs
            tabActions.Enabled = false;
            tabAdventure.Enabled = false;
            tabInv.Enabled = false;
            tabSettings.Enabled = false;

            //Set up our actions
            actions = new RPGAction[]{
                new RPGAction(new String[] { "⛏" }, pgsMine, cmdMine, chkMine),
                new RPGAction(new String[] { "🌼" }, pgsForage, cmdForage, chkForage),
                new RPGAction(new String[] { "🌴" }, pgsChop, cmdChop, chkChop),
                new RPGAction(new String[] { "🎣" }, pgsFish, cmdFish, chkFish),
            };
        }

        private void frmCombined_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Remember Settings
            Settings.Default.token = Settings.Default.rememberToken && !string.IsNullOrWhiteSpace(Settings.Default.token) ? Settings.Default.token : "";
            Settings.Default.Save();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtToken.Text.Length > 10) //Some length that I don't know right now but more than 10
            {
                

                cmdLogin.Enabled = false;
                txtToken.Enabled = false;
                chkRemember.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                if (botThread == null)
                {
                    //Start the Bot
                    //create a new bot
                    bot = new Bot(txtToken.Text);

                    //Connect events
                    bot.Client.Ready += bot_Ready;
                    bot.Client.MessageCreated += bot_MessageCreated;

                    //Cancellation Token allows us to stop the bot
                    tokenSource = new CancellationTokenSource();

                    //Run the bot on a new thread
                    botThread = Task.Run(botThreadCallback);
                }
                else
                {
                    //Stop the Bot
                    tokenSource.Cancel();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid login token.", "Invalid Token", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task botThreadCallback()
        {
            //Start the bot
            await bot.StartAsync().ConfigureAwait(false);

            //Bot has started
            Invoke(new Action(() =>
            {
                Settings.Default.token = txtToken.Text;
                Settings.Default.rememberToken = chkRemember.Checked;
                cmdLogin.Text = "Logout";
                pnlStats.Enabled = true;
                pnlMessages.Enabled = true;
                cmdLogin.Enabled = true;

                tabActions.Enabled = true;
                tabAdventure.Enabled = true;
                tabInv.Enabled = true;
                tabSettings.Enabled = true;
            }));

            // here we wait indefinitely, or until the wait is
            // cancelled
            try
            {
                // the token will cancel the way once it's 
                // requested
                await Task.Delay(-1, tokenSource.Token).ConfigureAwait(false);
            }
            catch { /* ignore the exception; it's expected */ }

            // Stop the bot
            await bot.StopAsync().ConfigureAwait(false);

            //Bot has stopped
            Invoke(new Action(() =>
            {
                cmdLogin.Text = "Login";
                pnlStats.Enabled = false;
                pnlMessages.Enabled = false;
                cmdLogin.Enabled = true;
                txtToken.Enabled = true;
                chkRemember.Enabled = true;

                tabActions.Enabled = false;
                tabAdventure.Enabled = false;
                tabInv.Enabled = false;
                tabSettings.Enabled = false;
            }));

            // and finally, dispose of our bot stuff
            bot = null;
            tokenSource = null;
            botThread = null;
        }

        private async Task sendMessage(string message, ulong id = 0)
        {
            if (id == 0)
            {
                id = Settings.Default.channel;
            }
            DiscordChannel chn = await bot.Client.GetChannelAsync(id);
            await chn.SendMessageAsync(message);
        }

        private Task bot_Ready(ReadyEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Text = bot.Client.CurrentUser.Username + "'s Adventure";
            }));
            return Task.CompletedTask;
        }

        private Task bot_MessageCreated(MessageCreateEventArgs e)
        {
            if (e.Author.Id == 170915625722576896 && e.Message.Content.Contains(bot.Client.CurrentUser.Username))
            {
                foreach (var action in actions)
                {
                    String message = e.Message.Content.ToLower();
                    if (action.matchingStrings.Any(message.Contains))
                    {
                        Invoke(new Action(() =>
                        {
                            action.progressBar.Value = 0;
                            action.button.Enabled = false;
                        }));
                    }
                }
                if (e.Message.Content.Contains("adventure"))
                {
                    Invoke(new Action(() =>
                    {
                        pgsAdv.Value = 0;
                        cmdAdv.Enabled = false;
                        lblAdventure.Text = e.Message.Content;
                    }));
                }
                if (e.Message.Content.Contains("healed"))
                {
                    Invoke(new Action(() =>
                    {
                        pgsHeal.Value = 0;
                        cmdHeal.Enabled = false;
                    }));
                }
                MessageBox.Show(e.Message.Content);
            }
            return Task.CompletedTask;
        }

        private void cmdMine_Click(object sender, EventArgs e)
        {
            sendMessage(">mine");
        }

        private void cmdForage_Click(object sender, EventArgs e)
        {
            sendMessage(">forage");
        }

        private void cmdChop_Click(object sender, EventArgs e)
        {
            sendMessage(">chop");
        }

        private void cmdFish_Click(object sender, EventArgs e)
        {
            sendMessage(">fish");
        }

        private void cmdSelected_Click(object sender, EventArgs e)
        {
            foreach (var action in actions)
            {
                if (action.checkBox.Checked)
                {
                    action.button.PerformClick();
                }
            }
        }

        private void cmdAdv_Click(object sender, EventArgs e)
        {
            sendMessage(">adv");
        }

        private void cmdHeal_Click(object sender, EventArgs e)
        {
            sendMessage(">heal");
        }

        private void tbcMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
        }

        private void cmdSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.channel = Convert.ToUInt64(txtChannel.Text);
            Settings.Default.Save();
        }
    }
}
