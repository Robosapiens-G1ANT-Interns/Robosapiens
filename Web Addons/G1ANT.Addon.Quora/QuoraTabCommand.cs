using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Quora
{
    [Command(Name = "quora.tab", Tooltip = "It jumps to the specified tab of the quora")]
    public class QuoraTabsCommand : Language.Command
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

        public QuoraTabsCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.quora.com/", arguments.Timeout.Value, arguments.NoWait.Value);

            if (arguments.tab.Value == "Home")
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[2]/div/div/div[1]/a/div/div[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Answer")
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[2]/div/div/a[1]/div/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Spaces")
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[2]/div/div/div[2]/div/div/div/div/div/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Notifications")
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[2]/div/div/a[2]/div/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Profile")
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[2]/div/div/div[4]/div/div[2]/div/div[1]/div/div/div[1]/a/div[1]/div/span";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            
        }
    }
}