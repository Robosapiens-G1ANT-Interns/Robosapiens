﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Naukri
{
    [Command(Name = "naukri.login", Tooltip = "Used to log in to naukri account")]
    public class NaukriLoginCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "loginID", Required = true, Tooltip = "Enter your login ID")]
            public TextStructure login { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Password", Required = true, Tooltip = "Enter your password")]
            public TextStructure pass { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Name of a variable where the command's result will be stored")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public NaukriLoginCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "/html/body/div[2]/div[1]/div/ul[1]/li[7]/a/div";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: true);

            arguments.Search.Value = "/html/body/div[2]/div[2]/div[2]/div/form/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.login.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div[2]/div[2]/div/form/div[3]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.pass.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div[2]/div[2]/div/form/div[5]/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: true);
        }
    }
}