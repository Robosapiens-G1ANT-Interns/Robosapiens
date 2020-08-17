using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.TumblrAndroid
{
    [Command(Name = "tumblrandroid.close", Tooltip = "This command closes Tumblr App session")]
    public class TumblrAndroidCloseCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {

        }

        public TumblrAndroidCloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = TumblrAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}

