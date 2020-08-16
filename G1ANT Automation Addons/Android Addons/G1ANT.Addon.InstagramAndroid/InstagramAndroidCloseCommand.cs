using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.InstagramAndroid
{
    [Command(Name = "instagramandroid.close", Tooltip = "Closes the instagram application instance in the connected android device.")]
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
            var driver = InstagramAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}