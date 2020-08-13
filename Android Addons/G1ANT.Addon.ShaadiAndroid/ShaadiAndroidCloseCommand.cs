using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.ShaadiAndroid
{
    [Command(Name = "shaadiandroid.close", Tooltip = "Closes the shaadi application instance in the connected android device.")]
    public class ShaadiAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public ShaadiAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = ShaadiAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}