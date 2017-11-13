using System.Threading.Tasks;
using System.Diagnostics;
using DSharpPlus;
using DSharpPlus.EventArgs;

namespace DiscordRPGui
{
    public class Bot
    {
        // the client instance, this is initialized with the class
        public DiscordClient Client { get; }

        // this instantiates the container class and the client
        public Bot(string token)
        {
            // create config from the supplied token
            var cfg = new DiscordConfiguration
            {
                Token = token,                   // use the supplied token
                TokenType = TokenType.Bot,       // log in as a bot

                AutoReconnect = true,            // reconnect automatically
                LogLevel = LogLevel.Debug,       // log everything
                UseInternalLogHandler = false    // we don't want the internal output logger
            };

            // initialize the client
            this.Client = new DiscordClient(cfg);

            // attach our own debug logger
            this.Client.DebugLogger.LogMessageReceived += this.DebugLogger_LogMessageReceived;
        }

        // this method logs in and starts the client
        public Task StartAsync()
            => this.Client.ConnectAsync();

        // this method logs out and stops the client
        public Task StopAsync()
            => this.Client.DisconnectAsync();

        // this method writes all of bot's log messages to debug output
        private void DebugLogger_LogMessageReceived(object sender, DebugLogMessageEventArgs e)
            => Debug.WriteLine($"[{e.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")}] [{e.Application}] [{e.Level}] {e.Message}");
    }
}
