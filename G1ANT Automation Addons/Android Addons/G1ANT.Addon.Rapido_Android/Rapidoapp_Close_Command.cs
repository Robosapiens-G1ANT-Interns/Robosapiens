﻿using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.RapidoApp
{
    [Command(Name = "rapidoapp.close", Tooltip = "This command is used to close the opened application on your device")]
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