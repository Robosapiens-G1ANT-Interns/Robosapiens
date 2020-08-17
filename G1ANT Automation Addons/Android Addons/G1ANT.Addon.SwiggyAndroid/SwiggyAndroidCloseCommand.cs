using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.SwiggyAndroid
{
    [Command(Name = "swiggyandroid.close", Tooltip = "This command closes Swiggy App session")]
    public class SwiggyAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public SwiggyAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = SwiggyAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

