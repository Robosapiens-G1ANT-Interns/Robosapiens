using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.SnapchatAndroid
{
    [Command(Name = "snapchatandroid.discover", Tooltip = "This command opens the discover Tab on the user's snapchat account.")]
    public class SnapchatAndroidDiscoverCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public SnapchatAndroidDiscoverCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.FrameLayout[@content-desc=]/android.view.View";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}