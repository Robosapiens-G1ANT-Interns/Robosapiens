using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.tab", Tooltip = "Open a tab in a specific facebook account.")]
    public class FacebookTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "tabname", Required = true, Tooltip = "Enter one of the tabs (lowercase): \nhome, watch, marketplace, groups, \ngaming, friends, messages, jobs, \nmemories, notifications")]
            public TextStructure tabname { get; set; }

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public FacebookTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.tabname.Value == "home")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "watch")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/watch/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "marketplace")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/marketplace/?ref=app_tabname", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "groups")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/groups/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "gaming")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/gaming/?ref=games_tabnamename", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "friends")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/friends/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "messages")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/messages/t/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "jobs")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/jobs/?source=bookmark", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "memories")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.facebook.com/?sk=h_chr", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "notifications")
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[1]/div[2]/div[4]/div[1]/div[1]/span/div/div[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
        }
    }
}