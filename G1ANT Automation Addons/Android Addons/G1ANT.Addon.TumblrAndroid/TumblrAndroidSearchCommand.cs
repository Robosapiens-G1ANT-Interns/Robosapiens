using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TumblrAndroid
{
    [Command(Name = "tumblrandroid.search", Tooltip = "...")]
    public class TumblrAndroidSearchCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Keyword", Required = true, Tooltip = "Enter keyword to search")]
            public TextStructure Key { get; set; } = new TextStructure(string.Empty);
        }

        public TumblrAndroidSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            //arguments.Search.Value = "//android.widget.ImageButton[@content-desc='EXPLORE']";
            arguments.Search.Value = "com.tumblr:id/topnav_explore_button_img_active";
            //arguments.By.Value = "xpath";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

            //arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.view.ViewGroup/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.TextView";
            arguments.Search.Value = "com.tumblr:id / widget_search_view";
            //arguments.By.Value = "xpath";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();



            //arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.EditText";
            arguments.Search.Value = "com.tumblr:id/searchable_action_bar";
            //arguments.By.Value = "xpath";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).SendKeys(arguments.Key.Value);
        }
    }
}