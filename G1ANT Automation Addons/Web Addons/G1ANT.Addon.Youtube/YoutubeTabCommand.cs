using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Youtube
{
    [Command(Name = "youtube.tab", Tooltip = "Enter option arguments as below: \nhome | trending | subscriptions | library | history")]
    public class YoutubeTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "option", Required = true, Tooltip = "Enter the option in the tab.")]
            public TextStructure Option { get; set; }

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public YoutubeTabCommand(AbstractScripter scripter) :
            base(scripter)
        {

        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.Option.Value == "home")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "trending")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/feed/trending", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "subscriptions")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/feed/subscriptions", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "library")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/feed/subscriptions", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "history")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/feed/history", arguments.Timeout.Value, arguments.NoWait.Value);
            }
        }
    }
}