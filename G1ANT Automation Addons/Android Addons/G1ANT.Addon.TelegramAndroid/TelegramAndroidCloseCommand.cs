using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.TelegramAndroid
{
    [Command(Name = "telegramandroid.close", Tooltip = "Closes the telegram application instance in the connected android device.")]
    public class TelegramAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public TelegramAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = TelegramAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}