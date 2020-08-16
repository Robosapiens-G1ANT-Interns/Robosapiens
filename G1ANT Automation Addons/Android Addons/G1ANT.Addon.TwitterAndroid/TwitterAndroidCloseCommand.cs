using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TwitterAndroid
{
    [Command(Name = "twitterandroid.close", Tooltip = "Closes the twitter application instance in the connected android device.")]
    public class TwitterAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public TwitterAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = TwitterAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}