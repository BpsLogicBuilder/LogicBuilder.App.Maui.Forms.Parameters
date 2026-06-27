using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Validation
{
    public class ValidatorArgumentParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string name = "min";
            object value = 5;
            Type type = typeof(int);

            // Act
            var parameters = new ValidatorArgumentParameters(
                name: name,
                value: value,
                type: type
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(value, parameters.Value);
            Assert.Equal(type, parameters.Type);
        }
    }
}
