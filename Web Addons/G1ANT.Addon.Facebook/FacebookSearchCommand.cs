using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.search", Tooltip = "Search for a specific keyword on facebook.")]
    public class FacebookSearchCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "keyword", Required = true, Tooltip = "Enter the search keyword")]
            public TextStructure keyword { get; set; }

            [Argument(Name = "filters", Required = false, Tooltip = "Enter one of the filters (lowercase): \n posts, people, photos, videos, marketplace, pages, places, groups, apps, events, links.")]
            public TextStructure filter { get; set; }

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public FacebookSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "/html/body/div[1]/div/div/div[1]/div[2]/div[2]/div/div/div/div/div[3]/label/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.keyword.Value, arguments, arguments.Timeout.Value);
            SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);

            if (arguments.filter.Value == "posts")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/posts/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "people")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/people/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "photos")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/photos/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "videos")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/videos/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "marketplace")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/marketplace/search/?query= {arguments.keyword.Value}", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "pages")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/pages/? q={arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "places")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/places/? q={arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "groups")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/groups/? q={arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "apps")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/apps/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "events")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/events/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.filter.Value == "links")
            {
                SeleniumManager.CurrentWrapper.Navigate($"https://www.facebook.com/search/links/?q= {arguments.keyword.Value}&__tsid__=0.43096615695448826&__epa__=SERP_TAB&__eps__=SERP_POSTS_TAB", arguments.Timeout.Value, arguments.NoWait.Value);
            }
        }
    }
}