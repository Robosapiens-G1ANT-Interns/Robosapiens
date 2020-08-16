﻿using G1ANT.Language;
using System;

namespace G1ANT.Addon.Uber.Variables
{
    [Variable(
        Name = "timeoutselenium",
        Tooltip = "Determines the timeout value (in ms) for several `selenium.` commands; the default value is 40000 (40 seconds)")]
    public class TimeoutSeleniumVariable : Variable
    {
        private TimeSpanStructure value;

        public TimeoutSeleniumVariable(AbstractScripter scripter = null) : base(scripter)
        {
            value = new TimeSpanStructure(new TimeSpan(0, 0, 40), "", scripter);
        }

        public override Structure GetValue(string index = null)
        {
            return value.Get(index);
        }

        public override void SetValue(Structure value, string index = null)
        {
            this.value.Set(value, index);
        }
    }
}