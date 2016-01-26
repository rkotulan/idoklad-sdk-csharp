using System.Linq;
using IdokladSdk.ApiFilters;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class CountryClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            Changes();
            int id = Countries();
            Country(id);
        }

        private void Country(int bankId)
        {
            // Act
            var result = ApiExplorer.Countries.Country(bankId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(bankId, result.Id);
        }

        private int Countries()
        {
            // Act
            var result = ApiExplorer.Countries.Countries();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.Countries.Changes(new ChangeFilter());

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
