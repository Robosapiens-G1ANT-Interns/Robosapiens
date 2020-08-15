using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Ola
{
    [Command(Name = "ola.search", Tooltip = "This searches for nearby cab")]
    public class OlaSearchCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Pickup Location", Required = true, Tooltip = "Enter your Pickup location")]
            public TextStructure pickup { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Drop Location", Required = true, Tooltip = "Enter your Drop location")]
            public TextStructure drop { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public OlaSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.olacabs.com/", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div/div/div[2]/div/div[2]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div/div/div[6]/div/div/div[2]/div/div/div[4]/div/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.pickup.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div/div/div[3]/div/div[2]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div/div/div[6]/div/div/div[2]/div/div/div[4]/div/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.drop.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div/div/div[5]/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

        }
    }
}