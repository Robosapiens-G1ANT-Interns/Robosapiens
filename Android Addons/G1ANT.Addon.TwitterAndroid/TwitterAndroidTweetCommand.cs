using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TwitterAndroid
{
    [Command(Name = "twitterandroid.tweet", Tooltip = "Tweet a message on the user's twitter profile.")]
    public class TwitterAndroidTweetCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "message text", Required = true, Tooltip = "Enter the text message that you want to tweet.")]
            public TextStructure Message { get; set; }
        }

        public TwitterAndroidTweetCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.ImageButton[@content-desc='New Tweet']";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

            arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='Edit Tweet 1 of 1']/android.widget.FrameLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).SendKeys(arguments.Message.Value);

            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}