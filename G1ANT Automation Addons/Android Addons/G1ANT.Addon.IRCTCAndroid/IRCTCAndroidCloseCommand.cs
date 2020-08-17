using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.IRCTCAndroid
{
    [Command(Name = "irctcandroid.close", Tooltip = "This command closes IRCTC App session")]
    public class IRCTCAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public IRCTCAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = IRCTCAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

