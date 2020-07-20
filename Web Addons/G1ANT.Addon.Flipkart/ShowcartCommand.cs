using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Flipkart
{
    [Command(Name = "flipkart.showcart", Tooltip = "Opens Cart Items page, make sure you have logged into the flipkart account.")]
    public class ShowcartCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(25000);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);
        }

        public ShowcartCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("www.flipkart.com", arguments.Timeout.Value, arguments.NoWait.Value);
            arguments.Search.Value = "/html/body/div/div/div[1]/div[1]/div[2]/div[5]/div/div/a";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
        }
    }
}