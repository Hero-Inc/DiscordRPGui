using System;
using System.Windows.Forms;

namespace DiscordRPGui
{
    public class RPGAction
    {
        public String[] matchingStrings;
        public ProgressBar progressBar;
        public Button button;
        public CheckBox checkBox;

        public RPGAction(String[] match, ProgressBar bar, Button button, CheckBox checkBox)
        {
            this.matchingStrings = match;
            this.progressBar = bar;
            this.button = button;
            this.checkBox = checkBox;
        }
    }
}
