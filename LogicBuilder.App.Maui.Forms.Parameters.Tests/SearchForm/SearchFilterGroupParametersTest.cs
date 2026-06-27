using LogicBuilder.App.Maui.Forms.Parameters.SearchForm;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.SearchForm
{
    public class SearchFilterGroupParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            ICollection<ISearchFilterParameters> filters =
            [
                new SearchFilterParameters("FirstName"),
                new SearchFilterParameters("LastName")
            ];

            // Act
            var parameters = new SearchFilterGroupParameters(
                filters: filters
            );

            // Assert
            Assert.Equal(filters, parameters.Filters);
            Assert.Equal(2, parameters.Filters.Count);
        }
    }
}
