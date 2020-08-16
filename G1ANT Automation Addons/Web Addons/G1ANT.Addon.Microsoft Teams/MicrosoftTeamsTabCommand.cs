using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.MicrosoftTeams
{
    [Command(Name = "microsoftteams.tab", Tooltip = "opens a tab in specific account")]
    public class MicrosoftTeamsTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "option", Required = true, Tooltip = "Enter the options in the tab")]
            public TextStructure options { get; set; }

            [Argument(Tooltip = "If set to 'true', the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public MicrosoftTeamsTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.options.Value == "chat")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/left-rail/div/div/left-rail-chat-tabs/div/left-rail-header/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.options.Value == "teams")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/left-rail/div/div/channel-list/left-rail-header/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.options.Value == "calls")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/left-rail/div/div/call-navigation/div/left-rail-header/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.options.Value == "files")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/left-rail/div/div/files-navigation/div/left-rail-header/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.options.Value == "apps")
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/app-bar/nav/ul/li[7]/discover-apps-button/button";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
        }
    }
}