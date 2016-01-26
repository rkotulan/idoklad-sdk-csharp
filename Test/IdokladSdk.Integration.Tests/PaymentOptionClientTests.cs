using System;
using System.Linq;
using IdokladSdk.ApiFilters;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class PaymentOptionClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            int id = PaymentOptions();
            PaymentOption(id);
            Changes();
        }

        private int PaymentOptions()
        {
            // Act
            var result = ApiExplorer.PaymentOptions.PaymentOptions();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Data, Is.Not.Null);
            Assert.That(result.Data.Count(), Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void PaymentOption(int id)
        {
            // Act
            var result = ApiExplorer.PaymentOptions.PaymentOption(id);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(id));
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.PaymentOptions.Changes(new ChangeFilter());

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}