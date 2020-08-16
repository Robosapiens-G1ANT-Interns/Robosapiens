using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Uber
{
    [Command(Name = "uber.logout", Tooltip = "This log out from your Uber account")]
    public class UberLogoutCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public UberLogoutCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://m.uber.com/looking?_ga=2.225212696.32350534.1597052993-2113446208.1597052993&uclick_id=a625c400-b5fb-4ceb-86ec-dd49c0424b79", arguments.Timeout.Value, arguments.NoWait.Value);

            SeleniumManager.CurrentWrapper.Navigate("https://riders.uber.com/profile?_ga=2.200004012.32350534.1597052993-2113446208.1597052993", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div/div/div[3]/div/div[2]/div/div[1]/div/div[3]/a";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
        }
    }
}
