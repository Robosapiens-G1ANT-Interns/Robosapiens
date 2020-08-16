using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.InstagramAndroid
{
    [Command(Name = "instagramandroid.activity", Tooltip = "This command opens the activitty Tab on the user's instagram account.")]
    public class InstagramAndroidActivityCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public InstagramAndroidActivityCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='Activity']";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}