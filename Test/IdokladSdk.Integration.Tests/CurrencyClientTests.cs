using System;
using System.Linq;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class CurrencyClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            int id = All();
            ById(id);
            Changes();
        }

        private int All()
        {
            // Act
            var result = ApiExplorer.Currencies.Currencies();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Data, Is.Not.Null);
            Assert.That(result.Data.Count(), Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void ById(int id)
        {
            // Act
            var result = ApiExplorer.Currencies.Currency(id);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(id));
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.Currencies.Changes(new DateTime(2015,1,1));

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}