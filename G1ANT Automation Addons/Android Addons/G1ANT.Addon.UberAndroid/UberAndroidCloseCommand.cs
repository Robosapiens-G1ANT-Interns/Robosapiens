using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.UberAndroid
{
    [Command(Name = "uberandroid.close", Tooltip = "This command closes Uber App session")]
    public class UberAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public UberAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = UberAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

