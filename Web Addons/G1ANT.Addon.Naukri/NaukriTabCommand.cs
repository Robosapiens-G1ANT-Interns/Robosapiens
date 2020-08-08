using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Naukri
{
    [Command(Name = "naukri.tab", Tooltip = "Opens a tab in specific Naukri account")]
    public class NaukriTabCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "tabname", Required = true, Tooltip = "Enter one of the tabs (lowercase): \n jobs, recruiters, companies, tools, services, .")]
            public TextStructure tabname { get; set; }

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public NaukriTabCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.tabname.Value == "jobs")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.naukri.com/browse-jobs", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "recruiters")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.naukri.com/recruiters", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "campanies")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.naukri.com/top-company-jobs", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "tools")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://insights.naukri.com/", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            else if (arguments.tabname.Value == "services")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://resume.naukri.com/resume-services?fftid=100001&id=", arguments.Timeout.Value, arguments.NoWait.Value);
            }
        }
    }
}