using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.QuoraAndroid
{
    [Command(Name = "quoraandroid.close", Tooltip = "This command closes Quora App session")]
    public class QuoraAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public QuoraAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = QuoraAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

