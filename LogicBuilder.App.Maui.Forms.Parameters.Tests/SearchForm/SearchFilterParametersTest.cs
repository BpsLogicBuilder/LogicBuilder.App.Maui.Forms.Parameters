using LogicBuilder.App.Maui.Forms.Parameters.SearchForm;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.SearchForm
{
    public class SearchFilterParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "FirstName";
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";

            // Act
            var parameters = new SearchFilterParameters(
                field: field,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
