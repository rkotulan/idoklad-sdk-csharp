using IdokladSdk.ApiModels;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class PriceListTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            PriceList contact = Default();
            contact = Create(contact);
            contact = Update(contact);
            contact = PriceList(contact.Id);
            PriceListExpand(contact.Id);
            Delete(contact.Id);
        }

        private void Delete(int id)
        {
            // Act
            var result = ApiExplorer.PriceList.Delete(id);

            // Assert
            Assert.IsTrue(result);
        }

        private void PriceListExpand(int id)
        {
            // Act
            var result = ApiExplorer.PriceList.PriceListItemExpand(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        private PriceList PriceList(int id)
        {
            // Act
            var result = ApiExplorer.PriceList.PriceListItem(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);

            return result;
        }

        private PriceList Update(PriceList model)
        {
            // Arrange
            model.Name = "Changed name";

            // Act
            var result = ApiExplorer.PriceList.Update(model.Id, model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(model.Name, result.Name);
            Assert.AreEqual(model.Id, result.Id);

            return result;
        }

        private PriceList Create(PriceList model)
        {
            // Arrange
            model.Name = "test price";
            model.Price = 199.5m;

            // Act
            var result = ApiExplorer.PriceList.Create(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(model.Name, result.Name);
            Assert.AreEqual(model.Price, result.Price);

            return result;
        }


        private PriceList Default()
        {
            // Act
            var result = ApiExplorer.PriceList.Default();

            // Assert
            Assert.IsNotNull(result);

            return result;
        }
    }
}
