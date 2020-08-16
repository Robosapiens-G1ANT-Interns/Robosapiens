using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.RedditAndroid
{
    [Command(Name = "redditandroid.close", Tooltip = "Closes the reddit application instance in the connected android device.")]
    public class RedditAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public RedditAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = RedditAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}