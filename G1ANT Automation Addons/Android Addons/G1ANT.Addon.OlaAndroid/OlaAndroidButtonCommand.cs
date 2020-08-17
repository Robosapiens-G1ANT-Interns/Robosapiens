using System;
using G1ANT.Language;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.OlaAndroid
{
    [Command(Name = "olaandroid.button", Tooltip = "This command clicks chosen element.")]
    public class OlaAndroidButtonCommand : Language.Command
    {
        public class Arguments : AppiumCommandArguments
        {
            [Argument(Required = true, Tooltip = "Keycode of the button to be pressed")]
            public TextStructure KeyCode { get; set; } = new TextStructure("");
        }

        public OlaAndroidButtonCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = OlaAndroidOpenCommand.GetDriver();
            string keycode = arguments.KeyCode.Value.ToLower();

            switch (keycode)
            {
                case "back":
                    driver.PressKeyCode(AndroidKeyCode.Back);

                    break;
                default:
                    throw new ArgumentException($"Provided button name is invalid.");
            }
        }
    }
}

