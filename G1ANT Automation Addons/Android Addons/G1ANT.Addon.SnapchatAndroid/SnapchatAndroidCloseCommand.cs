using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.SnapchatAndroid
{
    [Command(Name = "snapchatandroid.close", Tooltip = "Closes the snapchat application instance in the connected android device.")]
    public class SnapchatAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public SnapchatAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = SnapchatAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}
