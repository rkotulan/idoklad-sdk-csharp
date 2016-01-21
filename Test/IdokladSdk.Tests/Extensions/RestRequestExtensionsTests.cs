using System;
using System.Linq;
using IdokladSdk.ApiFilters;
using IdokladSdk.Extensions;
using NUnit.Framework;
using RestSharp;

namespace IdokladSdk.Tests.Extensions
{
    [TestFixture]
    public class RestRequestExtensionsTests
    {
        [Test]
        public void ApplyFiltersAsQueryString_ApiFilterInstance_ContainsAllMembers()
        {
            // Arrange
            var filter = new FakeFilter
            {
                PropertyOfString = "property1_data",
                PropertyOfInt = 12,
                PropertyOfDecimal = 9.2m,
                PropertyOfNullableInt = null,
                PropertyOfDate = new DateTime(2016, 05, 12),
                PropertyOfNullableDate = new DateTime(2016, 05, 12),
                PropertyOfFilterType = FilterType.Gt
            };

            // Act
            var request = new RestRequest();
            request.ApplyFiltersAsQueryString(filter);

            // Assert
            Assert.IsTrue(request.Parameters
                .Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfString" && x.Value.ToString() == "property1_data"));

            Assert.IsTrue(request.Parameters
                .Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfInt" && x.Value.ToString() == "12"));

            Assert.IsTrue(request.Parameters
                .Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfDecimal" && x.Value.ToString() == "9.2"));

            Assert.IsTrue(request.Parameters
                .Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfDate" && x.Value.ToString() == "2016-05-12"));

            Assert.IsTrue(request.Parameters
                .Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfNullableDate" && x.Value.ToString() == "2016-05-12"));

            Assert.IsTrue(request.Parameters
    .Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfFilterType" && x.Value.ToString() == "2"));

            Assert.IsFalse(request.Parameters.Any(x => x.Type == ParameterType.QueryString && x.Name == "PropertyOfNullableInt"));
        }
    }
}
