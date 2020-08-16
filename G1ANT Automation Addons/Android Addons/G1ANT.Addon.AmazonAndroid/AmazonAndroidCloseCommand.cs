using G1ANT.Addon.AmazonAndroid;
using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.AmazonAndroid
{
    [Command(Name = "amazonandorid.close", Tooltip = "This command closes Amzaon Android application.")]
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
            var driver = AmazonAndroidOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}