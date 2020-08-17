using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;


namespace G1ANT.Addon.QuoraAndroid
{
    public class AppiumCommandArguments : CommandArguments
    {
        [Argument(Required = false, Tooltip = "Provide name of capabilities")]
        public TextStructure Search { get; set; } = new TextStructure(string.Empty);

        [Argument(Required = false, Tooltip = "Provide element ID")]
        public TextStructure By { get; set; } = new TextStructure(string.Empty);

    }
}