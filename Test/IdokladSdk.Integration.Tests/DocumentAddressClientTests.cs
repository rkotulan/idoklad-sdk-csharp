using System;
using System.Globalization;
using System.Linq;
using IdokladSdk.ApiModels;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class DocumentAddressClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            var address = DocumentAddress();
            Update(address);
        }

        private DocumentAddress DocumentAddress()
        {
            // Act
            var invoices = ApiExplorer.IssuedInvoices.IssuedInvoices();
            int addressId = invoices.Data.FirstOrDefault().PurchaserDocumentAddressId;
            var result = ApiExplorer.DocumentAddresses.DocumentAddress(addressId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(addressId, result.Id);

            return result;
        }

        private void Update(DocumentAddress address)
        {
            // Arrange
            string random = new Random().Next(111111, 999999).ToString(CultureInfo.InvariantCulture);
            address.Firstname = random;

            // Act
            var result = ApiExplorer.DocumentAddresses.Update(address.Id, address);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Firstname, Is.EqualTo(random));
        }
    }
}
