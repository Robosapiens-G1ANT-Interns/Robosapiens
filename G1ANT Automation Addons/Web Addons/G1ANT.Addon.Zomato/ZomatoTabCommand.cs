using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Zomato
{
    [Command(Name = "zomato.tab", Tooltip = "This navigates to the specific tab")]
    public class ZomatoTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "tab", Required = true, Tooltip = "Enter into the spaecified tab")]
            public TextStructure tab { get; set; }

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public ZomatoTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.zomato.com/", arguments.Timeout.Value, arguments.NoWait.Value);

            if (arguments.tab.Value == "Profile")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[1]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Notifications")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[2]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Bookmarks")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[3]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Votes")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[4]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Networks")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[5]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Find friends")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[6]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Setting")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/header/nav/ul[2]/li[2]/div/div/div[2]/div[7]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
        }
    }
}

