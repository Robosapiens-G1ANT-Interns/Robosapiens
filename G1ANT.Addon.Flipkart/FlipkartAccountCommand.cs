using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Flipkart
{
    [Command(Name = "flipkart.account", Tooltip = "Select account specific options in argument:\n profile, supercoinzone, flipkartplus, orders, wishlist, mychats, coupons, giftcards, notifications, and logout. \n (make sure that the arguments are in lowercase) ")]
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
            
            

            if (arguments.Option.Value == "profile")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/account/?rd=0&link=home_account", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "supercoinzone")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/supercoin", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "flipkartplus")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/plus", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "orders")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/account/orders?link=home_orders", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "wishlist")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/wishlist?link=home_wishlist", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "mychats")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/my-chats?link=home_chat", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "coupons")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/account/rewards?link=home_rewards", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "giftcards")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/account/giftcard?link=home_giftcard", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "notifications")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/notifications?otracker=Notifications_view_all", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Option.Value == "logout")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.flipkart.com/account/?rd=0&link=home_account#", arguments.Timeout.Value, arguments.NoWait.Value);
            }

        }
    }
}