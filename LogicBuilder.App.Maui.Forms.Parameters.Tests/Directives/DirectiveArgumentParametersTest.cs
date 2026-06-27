using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Directives
{
    public class DirectiveArgumentParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string name = "maxLength";
            object value = 100;
            Type type = typeof(int);

            // Act
            var parameters = new DirectiveArgumentParameters(
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
