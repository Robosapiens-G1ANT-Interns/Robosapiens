using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.ZoomAndroid
{
    [Command(Name = "zoomandroid.close", Tooltip = "Closes the zoom application instance in the connected android device.")]
    public class ZoomAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public ZoomAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = ZoomAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}