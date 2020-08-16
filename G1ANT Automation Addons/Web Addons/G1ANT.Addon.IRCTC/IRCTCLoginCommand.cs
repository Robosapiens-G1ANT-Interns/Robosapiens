using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.IRCTC
{
    [Command(Name = "irctc.login", Tooltip = "This log into your IRCTC account")]
    public class IRCTCLoginCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Uesr ID", Required = true, Tooltip = "Enter your User ID")]
            public TextStructure userid { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Password", Required = true, Tooltip = "Enter your password")]
            public TextStructure password { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Name of a variable where the command's result will be stored")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public IRCTCLoginCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.irctc.co.in/nget/train-search", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[1]/app-header/p-dialog[2]/div/div[2]/div/form/div[2]/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[1]/app-header/div[2]/div[2]/div[1]/a[7]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/app-login/p-dialog/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/form/div[4]/div/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/app-login/p-dialog/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/form/div[1]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/app-login/p-dialog/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/form/div[1]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.userid.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/app-login/p-dialog/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/form/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/app-login/p-dialog/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/form/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.password.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/app-login/p-dialog/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/form/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
        }
    }
}
