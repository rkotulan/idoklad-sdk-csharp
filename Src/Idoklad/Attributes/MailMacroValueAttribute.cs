using System;

namespace IdokladSdk.Attributes
{
    internal class MailMacroValueAttribute : Attribute
    {
        public MailMacroValueAttribute(string value)
        {
            this.Value = value;
        }


        public string Value { get; set; }
    }
}