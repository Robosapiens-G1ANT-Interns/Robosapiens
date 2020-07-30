using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.FlipkartAndroid
{
    public class AppiumCommandArguments : CommandArguments
    {
        [Argument(Required = false, Tooltip = "Provide name of the capaility")]
        public TextStructure Search { get; set; } = new TextStructure(string.Empty);

        [Argument(Required = false, Tooltip = "Provide element ID")]
        public TextStructure By { get; set; } = new TextStructure(string.Empty);
    }
}
