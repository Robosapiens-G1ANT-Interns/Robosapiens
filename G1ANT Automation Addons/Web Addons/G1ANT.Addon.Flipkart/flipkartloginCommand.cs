using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;
using OpenQA.Selenium;

namespace G1ANT.Addon.Flipkart
{
    [Command(Name = "flipkart.login", Tooltip = "Opens a specified browseer instance with logged in flipkart account.")]
    public class FlipkartLoginCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Required = true ,Name = "browser", Tooltip = "Name of a web browser")]
            public TextStructure Name { get; set; }

            [Argument(DefaultVariable = "url", Tooltip = "Website Url")]
            public TextStructure url { get; set; } = new TextStructure("www.flipkart.com");

            [Argument(Name = "loginID", Required = true, Tooltip = "loginID")]
            public TextStructure LoginID { get; set; }

            [Argument(Name = "Password", Required = true, Tooltip = "login PASSWORD")]
            public TextStructure Password { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(500000);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

        }
    

        public FlipkartLoginCommand(AbstractScripter scripter) : base(scripter)
        {
        }


        // Implement this method
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumWrapper wrapper = SeleniumManager.CreateWrapper(
                    arguments.Name.Value,
                    arguments.url?.Value,
                    arguments.Timeout.Value,
                    arguments.NoWait.Value,
                    Scripter.Log,
                    Scripter.Settings.UserDocsAddonFolder.FullName);
                int wrapperId = wrapper.Id;
                OnScriptEnd = () =>
                {
                    SeleniumManager.DisposeAllOpenedDrivers();
                    SeleniumManager.RemoveWrapper(wrapperId);
                    SeleniumManager.CleanUp();
                };
                Scripter.Variables.SetVariableValue(arguments.Result.Value, new IntegerStructure(wrapper.Id));
            }
            catch (DriverServiceNotFoundException ex)
            {
                throw new ApplicationException("Driver not found", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Url '{arguments.url.Value}'. Message: {ex.Message}", ex);
            }
           
            
            arguments.Search.Value = "/html/body/div[2]/div/div/div/div/div[2]/div/form/div[1]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            SeleniumManager.CurrentWrapper.TypeText(arguments.LoginID.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "/html/body/div[2]/div/div/div/div/div[2]/div/form/div[2]/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            SeleniumManager.CurrentWrapper.TypeText(arguments.Password.Value, arguments, arguments.Timeout.Value);


            arguments.Search.Value = "/html/body/div[2]/div/div/div/div/div[2]/div/form/div[3]/button";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);

            

        }
    }
}