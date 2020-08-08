using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Telegram
{
    [Command(Name = "telegram.tab", Tooltip = "Open a tab in specific telegram account")]
    public class TelegramTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "tabname", Required = true, Tooltip = "Enter one of the tabs (lowercase): \nhome, ,news,region, \nliving, opinion, calender, ")]
            public TextStructure tabname { get; set; }

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public TelegramTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            

            if (arguments.tabname.Value == "home")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "news")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/news", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "region")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/localnews", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "sports")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/sports", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "opinion")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/opinion", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "living")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/living", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "calender")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/calendar", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "opinion")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/opinion", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "business")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.telegram.com/business", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "obituaries")
            {
                SeleniumManager.CurrentWrapper.Navigate("http://www.legacy.com/obituaries/telegram/?_ga=2.230877341.322925486.1596110337-1085056952.1596110337", arguments.Timeout.Value, arguments.NoWait.Value);

            }
        }
    }
}