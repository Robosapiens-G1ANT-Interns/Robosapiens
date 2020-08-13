using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.ViberAndroid
{
    [Command(Name = "viberandroid.close", Tooltip = "Closes the viber application instance in the connected android device.")]
    public class ViberAndroidCloseCommand : Language.Command
    {
       

        public class Arguments : AppiumCommandArguments
        {

        }

        public ViberAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = ViberAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}