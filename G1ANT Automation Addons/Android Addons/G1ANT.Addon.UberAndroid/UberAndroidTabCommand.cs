using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;
using OpenQA.Selenium.Appium.MultiTouch;

namespace G1ANT.Addon.UberAndroid
{
    [Command(Name = "uberandroid.tab", Tooltip = "...")]
    public class UberAndroidTabCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            
        }

        public UberAndroidTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout[2]";
            //arguments.Search.Value = "";
            arguments.By.Value = "xpath";
            //arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

            //TouchAction clickAction = new TouchAction(UberAndroidOpenCommand.GetDriver());
            //var coordinates = arguments.Search.Value.Split(',');
            //clickAction.Tap(int.Parse(coordinates[70]), int.Parse(coordinates[100])).Perform();
        }
    }
}