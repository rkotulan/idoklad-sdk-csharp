using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace IdokladSdk.Tests
{
    [TestFixture]
    public class ApiValidatorTests
    {
        [Test]
        public void ValidateObject_ObjectIsNotValid_ReturnsFals()
        {
            // Arrange
            var model = new FakeApiModel()
            {
                Firstname = "ReallyLongName",
                Lastname = null
            };

            List<ValidationMessage> errors;

            // Act
            bool isValid = ApiValidator.ValidateObject(model, out errors);

            // Assert
            Assert.That(isValid, Is.False);
            Assert.That(errors.Any(), Is.True);
        }
    }
}
