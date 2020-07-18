using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Flipkart
{
    [Command(Name = "flipkart.account", Tooltip = "Select account specific options in argument:\n profile, supercoinzone, flipkartplus, orders, wishlist, mychats, coupons, giftcards, notifications \n (make sure that the arguments are in lowercase) ")]
    public class FlipkartAccountCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "account option", Required = true, Tooltip = "Enter the Product name")]
            public TextStructure Option { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(25000);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);
        }

        public FlipkartAccountCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("www.flipkart.com", arguments.Timeout.Value, arguments.NoWait.Value);
            arguments.Search.Value = "/html/body/div/div/div[1]/div[1]/div[2]/div[3]/div/div/div/div";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);

            if (arguments.Option.Value == "profile")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "supercoinzone")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[2]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "flipkartplus")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[3]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "orders")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[4]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "wishlist")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[5]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "mychats")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[6]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "coupons")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[7]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "giftcards")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[8]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            if (arguments.Option.Value == "notifications")
            {
                arguments.Search.Value = "/div/div[2]/div/ul/li[9]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }

        }
    }
}