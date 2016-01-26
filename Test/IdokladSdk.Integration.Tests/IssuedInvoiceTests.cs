using System.Collections.Generic;
using System.Linq;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.IssuedInvoice;
using IdokladSdk.Enums;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class IssuedInvoicesTests : IntegrationTestBase
    {
        private const int ConstantSymbol = 1;

        [Test]
        public void IntegrationSteps()
        {
            IssuedInvoiceCreate createItem = this.Default();
            var item = this.Create(createItem);
            item = this.IssuedInvoices(item.Id);
            this.IssuedInvoicesByContact(item.PurchaserId);
            this.IssuedInvoicesByContactWithConstantSymbol(item.PurchaserId, new IssuedInvoiceFilter { ConstantSymbolId = ConstantSymbol });
            this.IssuedInvoicesExpand(item.Id);
            this.Delete(item.Id);
        }

        private void Delete(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.Delete(id);

            // Assert
            Assert.IsTrue(result);
        }

        private void IssuedInvoicesByContact(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.IssuedInvoicesByContact(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(id, result.Data.FirstOrDefault().PurchaserId);
        }

        private void IssuedInvoicesByContactWithConstantSymbol(int id, IssuedInvoiceFilter filter)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.IssuedInvoicesByContact(id, filter);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(id, result.Data.FirstOrDefault().PurchaserId);
            Assert.AreEqual(filter.ConstantSymbolId, result.Data.FirstOrDefault().ConstantSymbolId);
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
            model.ConstantSymbolId = ConstantSymbol;

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
