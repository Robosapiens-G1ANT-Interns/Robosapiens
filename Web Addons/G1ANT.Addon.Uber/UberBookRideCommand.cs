using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Uber
{
    [Command(Name = "uber.book", Tooltip = "This is used to book an Uber ride")]
    public class UberBookRideCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Pickup Location", Required = true, Tooltip = "Enter your Pickup Location")]
            public TextStructure pickup { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Drop Location", Required = true, Tooltip = "Enter your Drop Location")]
            public TextStructure drop { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Ride", Required = true, Tooltip = "This is used to book a ride")]
            public TextStructure ride { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public UberBookRideCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://m.uber.com/looking?_ga", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[1]/div/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[1]/div/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.pickup.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div/div[1]/div[2]/div[1]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[1]/div/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[1]/div/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.drop.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div/div[1]/div[2]/div[2]";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.NoWait.Value);

            if (arguments.ride.Value == "UberGo")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div[2]/div[2]/div[1]/div/div[2]/div[1]/div/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.ride.Value == "Premier")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div[2]/div[2]/div[1]/div/div[2]/div[1]/div/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.ride.Value == "UberAuto")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div[2]/div[2]/div[3]/div/div[2]/div[1]/div/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.ride.Value == "UberGo Rentals")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div[2]/div[2]/div[4]/div/div[2]/div[1]/div/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.ride.Value == "Uber XL")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div[2]/div[2]/div[5]/div/div[2]/div[1]/div/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }

            arguments.Search.Value = "/html/body/div[1]/div[2]/div[2]/div/div[3]/div[2]/div[2]/div[1]/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
        }
    }
}
