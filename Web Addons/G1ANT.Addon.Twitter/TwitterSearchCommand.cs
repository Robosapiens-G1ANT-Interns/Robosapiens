using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Twitter
{
    [Command(Name = "twitter.search", Tooltip = "Search for a keyword on the twitter database.")]
    public class TwitterSearchCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "keyword", Required = true, Tooltip = "Enter the keyword that you want to search in twitter")]
            public TextStructure keyword { get; set; }

            [Argument(Name = "filter", Required = true, Tooltip = "Enter filter from [top, latest, people, photos, videos]")]
            public TextStructure filter { get; set; }

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);
        }

        public TwitterSearchCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[1]/div[1]/div/div/div/div/div[1]/div[2]/div/div/div/form/div[1]/div/div/div[2]/input");
            arguments.By.Value = ("xpath");
            SeleniumManager.CurrentWrapper.TypeText(arguments.keyword.Value ,arguments, arguments.Timeout.Value);
            SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);

            if (arguments.filter.Value == "top")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[1]/div[2]/nav/div[2]/div[1]/a");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.filter.Value == "latest")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[1]/div[2]/nav/div[2]/div[2]/a");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.filter.Value == "people")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[1]/div[2]/nav/div[2]/div[3]/a");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.filter.Value == "photos")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[1]/div[2]/nav/div[2]/div[4]/a");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            else if (arguments.filter.Value == "videos")
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/div/div/div/div[1]/div[2]/nav/div[2]/div[5]/a");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
        }
    }
}