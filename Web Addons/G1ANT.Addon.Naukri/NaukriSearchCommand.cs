using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Naukri
{
    [Command(Name = "naukri.search", Tooltip = "Enter the keywords that you want to search in naukri")]
    public class NaukriSearchCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            internal object filter;

            // Enter all arguments you need
            [Argument(Name = "job", Required = true, Tooltip = "Enter the keyword that you want to search in naukri .")]
            public TextStructure job { get; set; }

            [Argument(Name = "location", Required = true, Tooltip = "Enter the keyword that you want to search in naukri .")]
            public TextStructure location { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");

        }

        public NaukriSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("https://www.naukri.com/mnjuser/homepage", arguments.Timeout.Value, arguments.NoWait.Value);


            arguments.Search.Value = ("/html/body/div[3]/div/div/span/div/div/div/div[1]/div/div/div[2]/div[1]/form/div[2]/div/div/div/div/div[1]/div/input");
            arguments.By.Value = ("xpath");
            SeleniumManager.CurrentWrapper.TypeText(arguments.job.Value, arguments, arguments.Timeout.Value);
        }
    }
}
