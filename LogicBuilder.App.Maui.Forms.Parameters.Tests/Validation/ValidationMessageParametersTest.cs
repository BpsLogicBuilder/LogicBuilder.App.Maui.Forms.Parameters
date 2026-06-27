using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Validation
{
    public class ValidationMessageParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "FirstName";
            var rules = new List<ValidationRuleParameters>
            {
                new("RequiredRule", "(Property) is required.")
            };
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";

            // Act
            var parameters = new ValidationMessageParameters(
                field: field,
                rules: rules,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(rules, parameters.Rules);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
