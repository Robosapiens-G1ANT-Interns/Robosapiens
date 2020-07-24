using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.FacebookAndroid
{
    [Command(Name = "fbandroid.close", Tooltip = "This command closes appium session")]
    public class CloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public CloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = FBandroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}