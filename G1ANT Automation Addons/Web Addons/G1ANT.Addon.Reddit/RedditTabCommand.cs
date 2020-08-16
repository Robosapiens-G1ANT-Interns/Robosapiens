using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Reddit
{
    [Command(Name = "reddit.tab", Tooltip = "Enter option arguments as below: popular | all| rpan | chat | inbox")]
    public class RedditTabCommand : Language.Command
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

        public RedditTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.Option.Value == "popular")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.reddit.com/r/popular/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "all")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.reddit.com/r/all/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "rpan")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.reddit.com/rpan/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "chat")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.reddit.com/chat", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.Option.Value == "inbox")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.reddit.com/message/inbox", arguments.Timeout.Value, arguments.NoWait.Value);
            }
        }
    }
    
}