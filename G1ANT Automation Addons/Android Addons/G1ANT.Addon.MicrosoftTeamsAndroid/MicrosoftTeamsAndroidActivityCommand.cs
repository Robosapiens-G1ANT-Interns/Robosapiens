using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;
using G1ANT.Addon.MicrosoftTeamsAndroid;

namespace G1ANT.Addon.MicrososoftTeamsAndroid
{
    [Command(Name = "microsoftteamsandroid.activity", Tooltip = "This command opens the activitty Tab on the user's microsoftteams account.")]
    public class MicrosoftTeamsAndroidActivityCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            public object Search { get; internal set; }
        }

        public MicrosoftTeamsAndroidActivityCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "//android.view.ViewGroup[@content-desc=]/android.widget.TextView";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
        }
    }
}