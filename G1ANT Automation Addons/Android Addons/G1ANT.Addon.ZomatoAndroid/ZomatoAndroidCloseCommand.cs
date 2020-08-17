using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.ZomatoAndroid
{
    [Command(Name = "zomatoandroid.close", Tooltip = "This command closes Zomato App session")]
    public class ZomatoAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public ZomatoAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = ZomatoAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

