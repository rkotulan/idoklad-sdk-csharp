using IdokladSdk.ApiModels;
using NUnit.Framework;

namespace IdokladSdk.Integration.Tests
{
    [TestFixture]
    public class ContactClientTests : IntegrationTestBase
    {
        [Test]
        public void IntegrationSteps()
        {
            Contact contact = this.Default();
            contact = this.Create(contact);
            contact = this.Update(contact);
            contact = this.Contact(contact.Id);
            this.ContactExpand(contact.Id);
            this.Contacts();
            this.ContactsExpand();
            this.Delete(contact.Id);
        }

        private void Delete(int id)
        {
            // Act
            var result = ApiExplorer.Contacts.Delete(id);

            // Assert
            Assert.IsTrue(result);
            Assert.That(ApiExplorer.Contacts.Contact(id), Is.Null);
        }

        private void ContactsExpand()
        {
            // Act
            var result = ApiExplorer.Contacts.ContactsExpand();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));
            Assert.That(result.TotalItems, Is.GreaterThan(0));
        }

        private void Contacts()
        {
            // Act
            var result = ApiExplorer.Contacts.Contacts();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.That(result.Data.Count, Is.GreaterThan(0));
            Assert.That(result.TotalItems, Is.GreaterThan(0));
        }

        private void ContactExpand(int id)
        {
            // Act
            var result = ApiExplorer.Contacts.ContactExpand(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        private Contact Contact(int id)
        {
            // Act
            var result = ApiExplorer.Contacts.Contact(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);

            return result;
        }

        private Contact Update(Contact contact)
        {
            // Arrange
            var put = (ContactPut)contact;
            put.Email = "thro@cent.x5";

            // Act
            var result = ApiExplorer.Contacts.Update(contact.Id, put);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(put.Email, result.Email);
            Assert.AreEqual(contact.Id, result.Id);

            return result;
        }

        private Contact Create(Contact contact)
        {
            // Arrange
            var post = (ContactPost)contact;
            post.Email = "alpha@cent.xx";
            post.CompanyName = "AlphaXX";

            // Act
            var result = ApiExplorer.Contacts.Create(post);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(post.Email, result.Email);
            Assert.AreEqual(post.CompanyName, result.CompanyName);

            return result;
        }

        private Contact Default()
        {
            // Act
            var result = ApiExplorer.Contacts.Default();

            // Assert
            Assert.IsNotNull(result);

            return result;
        }
    }
}
