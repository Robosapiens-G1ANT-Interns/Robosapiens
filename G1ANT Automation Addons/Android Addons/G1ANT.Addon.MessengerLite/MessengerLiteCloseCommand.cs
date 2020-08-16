using G1ANT.Addon.MessengerLite;
using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.MessengerLite
{
    [Command(Name = "messengerlite.close", Tooltip = "This command closes the messenger lite application.")]
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
            var driver = MessengerLiteOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}