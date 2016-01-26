using System;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class SystemClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            CodeBookChanges();
        }

        private void CodeBookChanges()
        {
            // Act
            var result = ApiExplorer.System.CodeBookChanges(new DateTime(2015, 1, 1));

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}