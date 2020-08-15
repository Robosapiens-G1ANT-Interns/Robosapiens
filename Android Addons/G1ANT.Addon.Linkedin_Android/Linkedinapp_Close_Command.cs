using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.LinkedinApp
{
    [Command(Name = "linkedinapp.close", Tooltip = "This command is used to login to linkedin android and perform close task")]
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
            var driver = OpenCommand.GetDriver();
            driver.Quit();
        }
    }
}