using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.MicrosoftTeamsAndroid
{
    [Command(Name = "microsoftteamsandroid.close", Tooltip = "Closes the microsoftteams application instance in the connected android device.")]
    public class MicrosoftTeamsAndroidCloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public MicrosoftTeamsAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = MicrosoftTeamsAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}