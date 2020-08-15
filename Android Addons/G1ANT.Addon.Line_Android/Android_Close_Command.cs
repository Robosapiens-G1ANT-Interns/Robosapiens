using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.LineAndroid
{
    [Command(Name = "lineandroid.close", Tooltip = "This command is used to close the open line android apk")]
    public class CloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public CloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = LineAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}