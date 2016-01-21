using System;
using IdokladSdk.Clients;
using NUnit.Framework;

namespace IdokladSdk.Tests.Clients
{
    [TestFixture]
    public class OAuthClientTests
    {
        [Test]
        public void GetSecureToken_UsernameNull_ThrowArgException()
        {
            Assert.Throws<ArgumentException>(delegate { new OAuthClient(string.Empty, "x"); });
        }

        [Test]
        public void GetSecureToken_PasswordNull_ThrowArgException()
        {
            Assert.Throws<ArgumentException>(delegate { new OAuthClient("x", string.Empty); });
        }
    }
}
