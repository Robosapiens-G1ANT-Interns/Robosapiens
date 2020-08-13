using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.IRCTC
{
    [Command(Name = "irctc.pnrstatus", Tooltip = "This is used to get the status of PNR")]
    public class IRCTCPNRstatusCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "PNR", Required = true, Tooltip = "Enter PNR here")]
            public TextStructure pnr { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public IRCTCPNRstatusCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.irctc.co.in/nget/train-search", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/app-root/app-home/div[2]/div/app-main-page/div[1]/div/div[1]/div/div/div[1]/div/app-jp-input/div[5]/div[1]/a/label";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div[2]/div[2]/div[2]/div[6]/div/div[2]/div/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.pnr.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div[2]/div[2]/div[6]/div/div[3]/div/div[2]/div/input[1]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

        }
    }
}