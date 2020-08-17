using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.OlaAndroid
{
    [Command(Name = "olaandroid.close", Tooltip = "This command closes Ola App session")]
    public class OlaAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public OlaAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = OlaAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

