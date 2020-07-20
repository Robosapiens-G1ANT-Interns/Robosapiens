using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;
using OpenQA.Selenium;
using Microsoft.JScript;

namespace G1ANT.Addon.Twitter
{
    [Command(Name = "twitter.login", Tooltip = "login to your twitter account by providing the useremail and password as arguments.")]
    public class TwitterLoginCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            // Enter all arguments you need
            [Argument(Name = "browser", Required = true)]
            public TextStructure Browser { get; set; }

            [Argument(Name = "email", Required = true, Tooltip = "Enter Login Email")]
            public TextStructure email { get; set; }

            [Argument(Name = "password", Required = true, Tooltip = "Enter Login Password")]
            public TextStructure password { get; set; }

            [Argument(Tooltip = "URL address of a webpage to be loaded")]
            public TextStructure Url { get; set; } = new TextStructure("www.twitter.com");

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Name of a variable where the command's result will be stored")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);

            
        }

        public TwitterLoginCommand(AbstractScripter scripter) : base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumWrapper wrapper = SeleniumManager.CreateWrapper(
                    arguments.Browser.Value,
                    arguments.Url?.Value,
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
                throw new ApplicationException($"Error occured while opening new selenium instance. Url '{arguments.Url.Value}'. Message: {ex.Message}", ex);
            }

            
            try
            {
                arguments.Search.Value = ("/html/body/div/div/div/div[2]/header/div[2]/div[1]/div/div[2]/div[1]/div[1]/a/div/span/span");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/form/div/div[1]/label/div/div[2]/div/input");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.TypeText(arguments.email.Value, arguments, arguments.Timeout.Value);

                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/form/div/div[2]/label/div/div[2]/div/input");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.TypeText(arguments.password.Value, arguments, arguments.Timeout.Value);

                arguments.Search.Value = ("/html/body/div/div/div/div[2]/main/div/div/form/div/div[3]/div/div");
                arguments.By.Value = ("xpath");
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while clicking element. Search element phrase: '{arguments.Search.Value}', by: '{arguments.By.Value}'. Message: {ex.Message}", ex);
            }
        }
    }
}