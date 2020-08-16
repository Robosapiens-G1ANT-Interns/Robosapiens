using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Twitter
{
    [Command(Name = "twitter.tab", Tooltip = "Enter a tab button to click: home, explore, notifications, messages, bookmarks, lists, profile, and more.")]
    public class TwitterTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "button", Required = true, Tooltip = "Tab button")]
            public TextStructure button { get; set; }

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);
        }

        public TwitterTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.button.Value == "home")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[1]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "explore")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[2]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "notifications")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[3]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "messages")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[4]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "bookmarks")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[5]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "lists")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[6]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "profile")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/a[7]");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.button.Value == "more")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[2]/nav/div");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }

        }
    }
}