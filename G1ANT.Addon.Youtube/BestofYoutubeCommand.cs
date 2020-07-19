using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Youtube
{
    [Command(Name = "youtube.bestofyoutube", Tooltip = "Browse specific genre of videos on youtube. \nEnter one of the genre from the list (lowercase): \nmusic | sports | gaming | movies | news | live | fashion | learning | spotlight | 360video")]
    public class BestofYoutubeCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "Genre", Required = true, Tooltip = "Enter one of the genre from the list (lowercase): \nmusic | sports | gaming | movies | news | live | fashion | learning | spotlight | 360video")]
            public TextStructure Genre { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public BestofYoutubeCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            if (arguments.Genre.Value == "music")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UC-9-kyTW8ZkZNDHQJ6FgpwQ", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "sports")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCEgdi0XIXXZ-qJOFPf4JSKw", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "gaming")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCEgdi0XIXXZ-qJOFPf4JSKw", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "movies")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UClgRkhTL3_hImCAmdLfDE4g", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "news")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCYfdidRxbB8Qhf0Nx7ioOYw", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "live")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UC4R8DWoMoI7CAwX8_LjQHig", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "fashion")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCrpQ4p1Ql_hG8rKXIKM1MOQ", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "learning")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCtFRv9O2AHqOZjjynzrv-xg", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "spotlight")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCvScgo6mAvbMEjszK4sSj6g", arguments.Timeout.Value, arguments.NoWait.Value);
            }
            if (arguments.Genre.Value == "360video")
            {
                SeleniumManager.CurrentWrapper.Navigate("https://www.youtube.com/channel/UCzuqhhs6NWbgTzMuM09WKDQ", arguments.Timeout.Value, arguments.NoWait.Value);
            }
        }
    }
}