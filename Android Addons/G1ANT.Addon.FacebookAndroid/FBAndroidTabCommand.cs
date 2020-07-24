using System;
using System.Diagnostics;
using System.Windows.Forms;
using G1ANT.Language;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.MultiTouch;


namespace G1ANT.Addon.FacebookAndroid
{
    [Command(Name = "fbandroid.tab", Tooltip = "Enter one of the tab names as shown below: \nhome, profile, notifications, friends, marketplace, groups, memories, \nvideos, saved, pages, events, jobs, nearbyfriends")]
    public class FBAndroidTabCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {
            // Enter all arguments you need
            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure(string.Empty);

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Tab Name", Required = true, Tooltip = "Provide element ID")]
            public TextStructure Tab { get; set; } = new TextStructure(string.Empty);
        }

        public FBAndroidTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.Tab.Value == "home")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='News Feed, Tab 1 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "profile")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Profile, Tab 3 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "notifications")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Notifications, Tab 5 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "friends")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[3]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "marketplace")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[4]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "groups")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[5]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "memories")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[6]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "videos")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[8]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "saved")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[7]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "pages")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[10]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "events")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[9]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "gaming")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[12]/android.view.ViewGroup";                
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "jobs")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[11]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
            if (arguments.Tab.Value == "nearbyfriends")
            {
                arguments.Search.Value = "//android.view.View[@content-desc='Menu, Tab 6 of 6']";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();

                arguments.Search.Value = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[13]/android.view.ViewGroup";
                arguments.By.Value = "xpath";

                ElementHelper.GetElement(arguments.By.Value, arguments.Search.Value).Click();
            }
        }
    }
}