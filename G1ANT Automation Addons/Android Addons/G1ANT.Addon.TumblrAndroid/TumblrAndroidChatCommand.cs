using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TumblrAndroid
{
    [Command(Name = "tumblrandroid.chat", Tooltip = "...")]
    public class TumblrAndroidChatCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            
        }

        public TumblrAndroidChatCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            //arguments.Search.Value = "//android.widget.ImageView[@content-desc='MESSAGES']";
            arguments.Search.Value = "com.tumblr:id/topnav_notification_button_img_active";
            //arguments.By.Value = "xpath";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}