﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Swiggy
{
    [Command(Name = "swiggy.tab", Tooltip = "This is used to navigate swiggy tabs")]
    public class SwiggyTabCommand : Language.Command
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

        public SwiggyTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.swiggy.com/restaurants", arguments.Timeout.Value, arguments.NoWait.Value);

            if (arguments.tab.Value == "Offers")
            {
                arguments.Search.Value = "/html/body/div[1]/div[1]/header/div/div/ul/li[4]/div/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Help")
            {
                arguments.Search.Value = "/html/body/div[1]/div[1]/header/div/div/ul/li[3]/div/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Account")
            {
                arguments.Search.Value = "/html/body/div[1]/div[1]/header/div/div/ul/li[2]/div/div/div/a/span[2]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.tab.Value == "Cart")
            {
                arguments.Search.Value = "/html/body/div[1]/div[1]/header/div/div/ul/li[1]/div/div/div/a/span[2]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
        }
    }
}