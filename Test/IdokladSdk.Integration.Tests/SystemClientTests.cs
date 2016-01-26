using System;
using IdokladSdk.ApiFilters;
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
            var result = ApiExplorer.System.CodeBookChanges(new ChangeFilter());

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}