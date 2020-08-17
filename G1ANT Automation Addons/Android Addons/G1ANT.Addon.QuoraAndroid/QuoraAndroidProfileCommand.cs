using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.QuoraAndroid
{
    [Command(Name = "quoraandroid.profile", Tooltip = "Click on 'Profile' tab option")]
    public class QuoraAndroidProfileCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public QuoraAndroidProfileCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.widget.ImageView[@content-desc='Me']";
            //arguments.Search.Value = "com.quora.android:id/navBarProfileImage";
            arguments.By.Value = "xpath";
            //arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}