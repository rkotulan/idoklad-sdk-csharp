using System;
using System.Collections.Generic;
using System.Linq;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
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
            IssuedInvoiceCreate createItem = Default();
            var item = Create(createItem);
            item = IssuedInvoices(item.Id);
            FullyPay(item.Id);
            FullyUnPay(item.Id);
            IssuedInvoicePdf(item.Id);
            IssuedInvoicePdfCompressed(item.Id);
            IssuedInvoicesByContact(item.PurchaserId);
            IssuedInvoicesByContactWithConstantSymbol(item.PurchaserId, new IssuedInvoiceFilter { ConstantSymbolId = ConstantSymbol });
            IssuedInvoicesExpand(item.Id);
            Delete(item.Id);
        }

        private void IssuedInvoicePdfCompressed(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.IssuedInvoicePdfCompressed(id);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Length, Is.GreaterThan(100));
        }

        private void IssuedInvoicePdf(int id)
        {
            // Act
            var result = ApiExplorer.IssuedInvoices.IssuedInvoicePdf(id);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Length, Is.GreaterThan(100));
        }

        private void FullyPay(int id)
        {
            // Arrange
            var paid = new DateTime(2016, 1, 1, 14, 0, 0);

            // Act
            var result = ApiExplorer.IssuedInvoices.FullyPay(id, paid);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(ApiExplorer.IssuedInvoices.IssuedInvoice(id).PaymentStatus, Is.EqualTo(PaymentStatusEnum.Paid));
        }

        private void FullyUnPay(int id)
        {
            // Arrange
            var paid = new DateTime(2016, 1, 1, 14, 0, 0);

            // Act
            ApiExplorer.IssuedInvoices.FullyPay(id, paid);
            var result = ApiExplorer.IssuedInvoices.FullyUnpay(id);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(ApiExplorer.IssuedInvoices.IssuedInvoice(id).PaymentStatus, Is.EqualTo(PaymentStatusEnum.Unpaid));
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
            Assert.IsNotNull(result.PurchaserDocumentAddress);
            Assert.IsNotNull(result.PurchaserDocumentAddress.Id);
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
