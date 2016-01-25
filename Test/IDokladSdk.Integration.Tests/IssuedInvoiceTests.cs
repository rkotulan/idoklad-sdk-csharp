using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.IssuedInvoice;
using IdokladSdk.Enums;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class IssuedInvoicesTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            IssuedInvoiceCreate createItem = this.Default();
            var item = this.Create(createItem);
            item = this.IssuedInvoices(item.Id);
            this.IssuedInvoicesExpand(item.Id);
            this.Delete(item.Id);
        }

        private void Delete(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.Delete(id);

            // Assert
            Assert.IsTrue(result);
            Assert.That(ApiExplorer.IssuedInvoices.IssuedInvoice(id), Is.Null);
        }

        private void IssuedInvoicesExpand(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.IssuedInvoiceExpand(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        private IssuedInvoice IssuedInvoices(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.IssuedInvoice(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);

            return result;
        }

        private IssuedInvoice Create(IssuedInvoiceCreate model)
        {
            // Arrange
            var purchaser = ApiExplorer.Contacts.Create(new ContactCreate() { CompanyName = "Test 9998" });

            model.IssuedInvoiceItems = new List<IssuedInvoiceItemWrite>()
            {
                new IssuedInvoiceItemWrite()
                {
                    Name = "PI A",
                    PriceType = PriceTypeEnum.OnlyBase,
                    Amount = 1,
                    UnitPrice = 100,
                }
            };
            model.Description = "Test description";
            model.PurchaserId = purchaser.Id;

            // Act
            var result = ApiExplorer.IssuedInvoices.Create(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(model.Description, result.Description);
            Assert.GreaterOrEqual(result.IssuedInvoiceItems.Count(), 1);

            return result;
        }


        private IssuedInvoiceCreate Default()
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.Default();

            // Assert
            Assert.IsNotNull(result);

            return result;
        }
    }
}
