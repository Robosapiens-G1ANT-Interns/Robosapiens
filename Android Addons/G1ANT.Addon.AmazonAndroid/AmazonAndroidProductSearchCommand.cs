using System;
using G1ANT.Language;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.AmazonAndroid
{
    [Command(Name = "amazonandroid.productsearch", Tooltip = "Searches for a product in the Amazon application.")]
    public class AmazonAndroidProductSearchCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            [Argument(Name = "search keyword", Required = true, Tooltip = "Search for a product")]
            public TextStructure product { get; set; } = new TextStructure(string.Empty);

        }

        public AmazonAndroidProductSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ViewAnimator/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            
            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ViewAnimator/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.EditText";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).SendKeys(arguments.product.Value);

            var driver = AmazonAndroidOpenCommand.GetDriver();

            driver.PressKeyCode(keyCode: 66, metastate: -1);

        }
    }
}