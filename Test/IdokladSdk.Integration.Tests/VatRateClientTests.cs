using System.Linq;
using IdokladSdk.ApiFilters;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class VatRateClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            Changes();
            int id = VatRates();
            VatRate(id);
        }

        private void VatRate(int bankId)
        {
            // Act
            var result = ApiExplorer.VatRates.VatRate(bankId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(bankId, result.Id);
        }

        private int VatRates()
        {
            // Act
            var result = ApiExplorer.VatRates.VatRates();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.VatRates.Changes(new ChangeFilter());

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
