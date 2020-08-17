using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.IRCTCAndroid
{
    [Command(Name = "irctcandroid.more", Tooltip = "...")]
    public class IRCTCAndroidMoreCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Tab Name", Required = true, Tooltip = "Enter Tab Name")]
            public TextStructure Tab { get; set; } = new TextStructure("");
        }

        public IRCTCAndroidMoreCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[4]";
            //arguments.Search.Value = "cris.org.in.prs.ima:id/more_drawer";
            arguments.By.Value = "xpath";
            //arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            
            if(arguments.Tab.Value == "Alerts")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[1]";
                //arguments.Search.Value = "cris.org.in.prs.ima:id/rl_alerts";
                arguments.By.Value = "xpath";
                //arguments.By.Value = "id";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "Gallery")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[7]";
                //arguments.Search.Value = "cris.org.in.prs.ima:id/rl_gallery";
                arguments.By.Value = "xpath";
                //arguments.By.Value = "id";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "About us")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[8]";
                //arguments.Search.Value = "cris.org.in.prs.ima:id/rl_about_us";
                arguments.By.Value = "xpath";
                //arguments.By.Value = "id";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "Contact us")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[9]";
                //arguments.Search.Value = "cris.org.in.prs.ima:id/rl_contact_us";
                arguments.By.Value = "xpath";
                //arguments.By.Value = "id";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "Fundamental Duties")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[9]";
                //arguments.Search.Value = "cris.org.in.prs.ima:id/rl_fundamental_duties";
                arguments.By.Value = "xpath";
                //arguments.By.Value = "id";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "User Guide")
            {
                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.RelativeLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout[10]";
                //arguments.Search.Value = "cris.org.in.prs.ima:id/rl_user_guide";
                arguments.By.Value = "xpath";
                //arguments.By.Value = "id";
                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
        }
    }
}