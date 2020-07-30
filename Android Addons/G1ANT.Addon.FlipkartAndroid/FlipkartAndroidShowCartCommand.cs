using G1ANT.Language;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.FlipkartAndroid
{
    [Command(Name = "flipkartandroid.showcart", Tooltip = "shows the cart contents in the flipkart app.")]
    public class FlipkartAndroidShowCartCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public FlipkartAndroidShowCartCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.RelativeLayout[@content-desc='Shopping Cart']/android.widget.LinearLayout";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }

    }
}