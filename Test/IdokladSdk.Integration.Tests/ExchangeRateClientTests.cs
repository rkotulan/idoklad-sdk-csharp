using System;
using System.Linq;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class ExchangeRateClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            int id = All();
            ById(id);
        }

        private int All()
        {
            // Act
            var result = ApiExplorer.ExchangeRates.ExchangeRates();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Data, Is.Not.Null);
            Assert.That(result.Data.Count(), Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void ById(int id)
        {
            // Act
            var result = ApiExplorer.ExchangeRates.ExchangeRate(id);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(id));
        }
    }
}