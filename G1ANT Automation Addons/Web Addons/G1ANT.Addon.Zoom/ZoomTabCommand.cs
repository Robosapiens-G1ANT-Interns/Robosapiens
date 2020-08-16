using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Zoom
{
    [Command(Name = "zoom.tab", Tooltip = "Open a tab in a specific zoom account")]
    public class ZoomTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "tabname", Required = true, Tooltip = "Enter one of the tabs (lowercase): \nhome, watch, marketplace, groups, \ngaming, friends, messages, jobs, \nmemories, notifications")]
            public TextStructure tabname { get; set; }

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public ZoomTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.tabname.Value == "profile")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/profile", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "meeting")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/meeting", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "webinar")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/webinar/whatis", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "recording")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/recording", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "setting")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/profile/setting", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "schedule a meeting")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/meeting/schedule", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "join a meeting")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://us04web.zoom.us/join", arguments.Timeout.Value, arguments.NoWait.Value);
            }
        }
    }
}