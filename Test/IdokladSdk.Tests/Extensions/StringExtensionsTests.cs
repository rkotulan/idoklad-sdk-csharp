using IdokladSdk.Extensions;
using NUnit.Framework;

namespace IdokladSdk.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [TestCase("text")]
        [TestCase("\"quote\"")]
        [TestCase("the\"quote \" space")]
        public void RemoveQuotationMarks(string text)
        {
            Assert.IsFalse(text.RemoveQuotationMarks().Contains("\""));
        }

        [TestCase("")]
        [TestCase(null)]
        public void IsNullOrEmpty_Empty_True(string text)
        {
            Assert.IsTrue(text.IsNullOrEmpty());
        }

        [TestCase(" ")]
        [TestCase("txt")]
        public void IsNullOrEmpty_NotEmpty_False(string text)
        {
            Assert.IsFalse(text.IsNullOrEmpty());
        }
    }
}
