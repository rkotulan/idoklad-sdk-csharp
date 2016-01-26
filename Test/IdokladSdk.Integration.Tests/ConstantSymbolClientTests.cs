using System.Linq;
using IdokladSdk.ApiFilters;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class ConstantSymbolClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            Changes();
            int id = ConstantSymbols();
            ConstantSymbol(id);
        }

        private void ConstantSymbol(int bankId)
        {
            // Act
            var result = ApiExplorer.ConstantSymbols.ConstantSymbol(bankId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(bankId, result.Id);
        }

        private int ConstantSymbols()
        {
            // Act
            var result = ApiExplorer.ConstantSymbols.ConstantSymbols();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));

            return result.Data.FirstOrDefault().Id;
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.ConstantSymbols.Changes(new ChangeFilter());

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
