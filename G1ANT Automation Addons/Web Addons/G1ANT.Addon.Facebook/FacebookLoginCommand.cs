using G1ANT.Language;
using OpenQA.Selenium;
using System;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.login", Tooltip = "Used to log into the facebook account")]
    public class FacebookLoginCommand : Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "loginID", Required = true, Tooltip = "Enter your login ID")]
            public TextStructure login { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Password", Required = true, Tooltip = "Enter your password")]
            public TextStructure pass { get; set; } = new TextStructure(string.Empty);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "Name of a variable where the command's result will be stored")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public FacebookLoginCommand(AbstractScripter scripter) : base(scripter)
        {
        }

        // Implement this method
        
        public void Execute(Arguments arguments)
        {
            try
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);
                SeleniumManager.CurrentWrapper.TypeText(arguments.login.Value, arguments, arguments.Timeout.Value);

                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[2]/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);
                SeleniumManager.CurrentWrapper.TypeText(arguments.pass.Value, arguments, arguments.Timeout.Value);

                arguments.Search.Value = "/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while typing text to element. Text: '{arguments.login.Value}' or '{arguments.pass.Value}'. 'Search element phrase: '{arguments.Search.Value}', by: '{arguments.By.Value}'. Message: {ex.Message}", ex);
            }
        }
    }
}