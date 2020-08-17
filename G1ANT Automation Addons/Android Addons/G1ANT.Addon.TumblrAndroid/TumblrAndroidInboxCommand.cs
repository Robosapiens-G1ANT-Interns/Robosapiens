using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TumblrAndroid
{
    [Command(Name = "tumblrandroid.inbox", Tooltip = "...")]
    public class TumblrAndroidInboxCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            
        }

        public TumblrAndroidInboxCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            //arguments.Search.Value = "//android.widget.ImageView[@content-desc='Inbox']";
            arguments.Search.Value = "com.tumblr:id/iv_inbox";
            //arguments.By.Value = "xpath";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}