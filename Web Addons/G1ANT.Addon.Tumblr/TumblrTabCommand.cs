using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Tumblr
{
    [Command(Name = "tumblr.tab", Tooltip = "It is used to nevigate the specific tabs of the tumbler")]
    public class TumblrTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "TumblrTabs", Required = true, Tooltip = "...")]
            public TextStructure Options { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public TumblrTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.tumblr.com/dashboard", arguments.Timeout.Value, arguments.NoWait.Value);

            if (arguments.Options.Value == "dashboard")
            {
                arguments.Search.Value = "/html/body/div[2]/div[1]/div[1]/div/div[1]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
            }
            else if (arguments.Options.Value == "explore")
            {
                arguments.Search.Value = "/html/body/div[2]/div[1]/div[1]/div/div[2]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
            }
            else if (arguments.Options.Value == "inbox")
            {
                arguments.Search.Value = "/html/body/div[2]/div[1]/div[1]/div/div[3]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
            }
            else if (arguments.Options.Value == "activity")
            {
                arguments.Search.Value = "/html/body/div[2]/div[1]/div[1]/div/div[5]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
            }
            else if (arguments.Options.Value == "account")
            {
                arguments.Search.Value = "/html/body/div[2]/div[1]/div[1]/div/div[6]/button/i";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
            }
        }
    }
}