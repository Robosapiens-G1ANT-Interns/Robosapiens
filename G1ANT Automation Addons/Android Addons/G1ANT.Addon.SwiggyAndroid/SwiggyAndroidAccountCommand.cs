using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium;

namespace G1ANT.Addon.SwiggyAndroid
{
    [Command(Name = "swiggyandroid.account", Tooltip = "This navigate to the 'account' tab of Swiggy App")]
    public class SwiggyAndroidAccountCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public SwiggyAndroidAccountCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout[1]/android.widget.FrameLayout";
            //arguments.Search.Value = "";
            arguments.By.Value = "xpath";
            //arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            //TouchAction clickAction = new TouchAction(SwiggyAndroidOpenCommand.GetDriver());
            //var coordinates = arguments.Search.Value.Split(',');
            //clickAction.Tap(int.Parse(coordinates[262]), int.Parse(coordinates[1283])).Perform();
        }
    }
}