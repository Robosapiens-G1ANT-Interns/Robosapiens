using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Tumblr
{
    [Command(Name = "tumblr.login", Tooltip = "This will log into your tumbler handle")]
    public class TumblrLoginCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need

            [Argument(Name = "Email", Required = true, Tooltip = "Enter your login ID")]
            public TextStructure Emailid { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Password", Required = true, Tooltip = "Enter your password")]
            public TextStructure Password { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public TumblrLoginCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div[2]/div[1]/div[3]/div[1]/button[2]/span";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div[2]/div[1]/div[3]/div[1]/div[1]/div/form/div[2]/div/input[1]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(
                    arguments.Emailid.Value,
                    arguments,
                    arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div[1]/div[3]/div[1]/button[1]/span[2]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div[2]/div[1]/div[3]/div[1]/div[1]/div/form/div[7]/div[2]/a";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div[2]/div[1]/div[3]/div[1]/div[1]/div/form/div[2]/div/input[1]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(
                    arguments.Password.Value,
                    arguments,
                    arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div[1]/div[3]/div[1]/button[1]/span[6]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);


        }
    }
}