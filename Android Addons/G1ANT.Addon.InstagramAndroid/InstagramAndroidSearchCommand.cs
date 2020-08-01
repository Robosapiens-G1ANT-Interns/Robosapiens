using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.InstagramAndroid
{
    [Command(Name = "instagramandroid.searchandexplore", Tooltip = "This command is used to search a keyword or string in the instagram mobile app or with empty arguments it will just open the explore tab.")]
    public class InstagramAndroidSearchCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Keyword", Required = true, Tooltip = "Enter the search keyword.")]
            public TextStructure Keyword { get; set; } = new TextStructure("");

            [Argument(Name = "filter", Required = true, Tooltip = "Enter the filter from the following: top, accounts, tags, places")]
            public TextStructure Filter { get; set; } = new TextStructure("");
        }

        public InstagramAndroidSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.Keyword.Value == "" && arguments.Filter.Value == "")
            {
                arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='Search and Explore']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else
            {
                arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='Search and Explore']";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='Scroll to top']/android.widget.LinearLayout/android.widget.EditText";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='Scroll to top']/android.widget.LinearLayout/android.widget.EditText";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).SendKeys(arguments.Keyword.Value);

                var driver = InstagramAndroidOpenCommand.GetDriver();

                driver.PressKeyCode(keyCode: 66, metastate: -1);

                if (arguments.Filter.Value == "top")
                {
                    arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[1]";
                    arguments.By.Value = "xpath";
                    ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
                }
                else if (arguments.Filter.Value == "accounts")
                {
                    arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[2]";
                    arguments.By.Value = "xpath";
                    ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
                }
                else if (arguments.Filter.Value == "tags")
                {
                    arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[3]";
                    arguments.By.Value = "xpath";
                    ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
                }
                else if (arguments.Filter.Value == "places")
                {
                    arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[4]";
                    arguments.By.Value = "xpath";
                    ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
                }
            }
            
        }
    }
}