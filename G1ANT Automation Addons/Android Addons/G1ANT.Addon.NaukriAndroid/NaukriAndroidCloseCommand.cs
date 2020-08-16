using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.NaukriAndroid
{
    [Command(Name = "naukriandroid.close", Tooltip = "Closes the naukri application instance in the connected android device.")]
    public class NaukriAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public NaukriAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = NaukriAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}