using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TwitterAndroid
{
    [Command(Name = "twitterandroid.search", Tooltip = "Search of a keyword or string in the twitter app.")]
    public class TwitterAndroidSearchCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Keyword", Required = true, Tooltip = "Enter the search keyword.")]
            public TextStructure Keyword { get; set; }

            [Argument(Name = "filter", Required = true, Tooltip = "Enter the filter from the following: top, latest, people, photos, videos")]
            public TextStructure Filter { get; set; }
        }

        public TwitterAndroidSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//androidx.appcompat.app.a.c[@content-desc='Explore']/android.view.View";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.LinearLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.TextView";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

            arguments.Search.Value = "//android.widget.EditText[@content-desc='Search']";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).SendKeys(arguments.Keyword.Value);

            var driver = TwitterAndroidOpenCommand.GetDriver();

            driver.PressKeyCode(keyCode: 66, metastate: -1);

            if (arguments.Filter.Value == "top")
            {
                arguments.Search.Value = "//androidx.appcompat.app.a.c[@index='0']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else if (arguments.Filter.Value == "latest")
            {
                arguments.Search.Value = "//androidx.appcompat.app.a.c[@index='1']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else if (arguments.Filter.Value == "people")
            {
                arguments.Search.Value = "//androidx.appcompat.app.a.c[@index='2']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else if (arguments.Filter.Value == "photos")
            {
                arguments.Search.Value = "//androidx.appcompat.app.a.c[@index='3']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else if (arguments.Filter.Value == "vidoes")
            {
                arguments.Search.Value = "//androidx.appcompat.app.a.c[@index='4']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
        }
    }
}