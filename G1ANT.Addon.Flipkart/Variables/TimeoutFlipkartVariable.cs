using G1ANT.Language;
using System;

namespace G1ANT.Addon.Flipkart.Variables
{
    [Variable(
        Name = "timeoutflipkart",
        Tooltip = "Determines the timeout value (in ms) for several `flipkart.` commands; the default value is 500000 (500 seconds)")]
    public class TimeoutSeleniumVariable : Variable
    {
        private TimeSpanStructure Value;

        public TimeoutSeleniumVariable(AbstractScripter scripter = null) : base(scripter)
        {
            Value = new TimeSpanStructure(new TimeSpan(0, 0, 500), "", scripter);
        }

        public override Structure GetValue(string index = null)
        {
            return Value.Get(index);
        }

        public override void SetValue(Structure value, string index = null)
        {
            this.Value.Set(value, index);
        }
    }
}
