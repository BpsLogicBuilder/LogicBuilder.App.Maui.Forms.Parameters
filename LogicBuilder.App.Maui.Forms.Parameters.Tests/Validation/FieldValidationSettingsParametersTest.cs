using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Validation
{
    public class FieldValidationSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            object? defaultValue = "DefaultText";
            var validators = new List<ValidatorDefinitionParameters>
            {
                new("RequiredRule", "Check")
            };

            // Act
            var parameters = new FieldValidationSettingsParameters(
                defaultValue: defaultValue,
                validators: validators
            );

            // Assert
            Assert.Equal(defaultValue, parameters.DefaultValue);
            Assert.Equal(validators, parameters.Validators);
        }
    }
}
