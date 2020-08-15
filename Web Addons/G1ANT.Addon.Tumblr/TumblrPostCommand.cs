using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Tumblr
{
    [Command(Name = "tumblr.post", Tooltip = "Used to post on tumblr")]
    public class TumblrPostCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Post", Required = true, Tooltip = "Post on tumblr")]
            public TextStructure Postmessage { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(true);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public TumblrPostCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.tumblr.com/dashboard", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div/div[2]/div/div[2]/div/nav/div/div/ul[1]/li[1]/a/span";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            arguments.Search.Value = "/html/body/div/div[1]/div[2]/div[1]/div[1]/div[2]/div/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.Postmessage.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div/div[1]/div[2]/div[2]/div[1]/div[1]/button/span";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
        }
    }
}