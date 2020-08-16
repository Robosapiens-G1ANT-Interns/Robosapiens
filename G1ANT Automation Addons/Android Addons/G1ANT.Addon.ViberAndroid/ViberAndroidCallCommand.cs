using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.ViberAndroid
{
    [Command(Name = "viberandroid.call", Tooltip = "This command opens the call Tab on the user's viber account.")]
    public class ViberAndroidCallCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public ViberAndroidCallCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.FrameLayout[@content-desc='call']";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}