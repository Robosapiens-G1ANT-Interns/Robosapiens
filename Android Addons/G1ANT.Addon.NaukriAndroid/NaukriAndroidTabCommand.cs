using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.NaukriAndroid
{
    [Command(Name = "naukriandroid.tab", Tooltip = "Access various elements of the Tab section in the naukri application.")]
    public class NaukriAndroidTabCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Option", Required = true, Tooltip = "Enter one of the options: search job, applied jobs, , saved jobs, ")]
            public TextStructure Option { get; set; }
        }

        public NaukriAndroidTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.ImageButton[@content-desc='Navigate up'] ";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

            if (arguments.Option.Value == "search jobs")
            {
                arguments.Search.Value = "naukriApp.appModules.login:id/widget_logo";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else if (arguments.Option.Value == "saved jobs")
            {
                arguments.Search.Value = "naukriApp.appModules.login:id/fraud_banner_desc ";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            else if (arguments.Option.Value == "applied jobs")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup[2]/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.RelativeLayout[1]/android.widget.LinearLayout[5]/android.widget.TextView[1]";
                arguments.By.Value = "xpath";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
        }
    }
}