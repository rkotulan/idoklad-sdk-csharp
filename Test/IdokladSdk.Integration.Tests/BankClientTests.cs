using System;
using System.Collections.Generic;
using System.Linq;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.ReadOnlyEntites;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class BankClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            this.Changes();
            var banks = this.Banks();
            this.Bank(banks.FirstOrDefault().Id);
        }

        private void Bank(int bankId)
        {
            // Act
            var result = ApiExplorer.BankClients.Bank(bankId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(bankId, result.Id);
        }

        private List<Bank> Banks()
        {
            // Act
            var result = ApiExplorer.BankClients.Banks();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));

            return result.Data;
        }

        private void Changes()
        {
            // Act
            var result = ApiExplorer.BankClients.Changes(new ChangeFilter());

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
