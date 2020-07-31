using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Twitter
{
    [Command(Name = "twitter.tweet", Tooltip = "Tweet a message on twitter.")]
    public class TwitterTweetCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "message", Required = true, Tooltip = "Enter the message that you want to tweet in twitter.")]
            public TextStructure message { get; set; }

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);
        }

        public TwitterTweetCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div/div/div/div[1]/div[3]/a");
            arguments.By.Value = ("xpath");
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: true);

            arguments.Search.Value = ("/html/body/div/div/div/div[1]/div[2]/div/div/div/div/div/div[2]/div[2]/div/div[3]/div/div/div/div[1]/div/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div/div/div[1]/div/div/div/div[2]/div/div/div/div");
            arguments.By.Value = ("xpath");
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: true);
            KeyboardTyper.Type(arguments.message.Value, window: "chrome", mainWindowHandle: null, lastWindow: (IntPtr)0, delay: 2, checkMode: false, keyboardWait: false, timeout: 5000);


            arguments.Search.Value = ("/html/body/div/div/div/div[1]/div[2]/div/div/div/div/div/div[2]/div[2]/div/div[3]/div/div/div/div[1]/div/div/div/div/div[2]/div[4]/div/div/div[2]/div[4]");
            arguments.By.Value = ("xpath");
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);

        }
    }
}