﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Shaadi
{
    [Command(Name = "shaadi.logout", Tooltip = "Log out of a signed in shaadi Account")]
    public class ShaadiLogoutCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public ShaadiLogoutCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.shaadi.com/registration/user/complete-logout", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div[2]/div/div[1]/div/div[2]/div[4]/div";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div/div[1]/div/div[2]/div[4]/div/div[2]/div/div[4]/div[2]/ul/li[3]/a";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
        }
    }
}