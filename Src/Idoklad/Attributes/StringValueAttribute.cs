using System;

namespace IdokladSdk.Attributes
{
    internal class StringValueAttribute : Attribute
    {
        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }

        public string StringValue { get; protected set; }
    }
}