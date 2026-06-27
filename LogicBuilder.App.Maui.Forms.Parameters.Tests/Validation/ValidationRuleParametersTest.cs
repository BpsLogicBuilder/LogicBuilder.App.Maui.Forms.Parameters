using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Validation
{
    public class ValidationRuleParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string className = "RequiredRule";
            string message = "(Property) is required.";

            // Act
            var parameters = new ValidationRuleParameters(
                className: className,
                message: message
            );

            // Assert
            Assert.Equal(className, parameters.ClassName);
            Assert.Equal(message, parameters.Message);
        }
    }
}
