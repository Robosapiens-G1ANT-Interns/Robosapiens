using G1ANT.Addon.Whatsapp;
using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.FacebookAndroid
{
    [Command(Name = "whatsapp.close", Tooltip = "This command closes whatsapp application.")]
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
            var driver = WhatsappOpenCommand.GetDriver();
            driver.Quit();
        }
    }
}