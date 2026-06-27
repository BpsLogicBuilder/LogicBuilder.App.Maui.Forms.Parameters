using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Validation
{
    public class ValidatorDefinitionParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string className = "RequiredRule";
            string functionName = "Check";
            var arguments = new List<ValidatorArgumentParameters>
            {
                new("min", 5, typeof(int))
            };

            // Act
            var parameters = new ValidatorDefinitionParameters(
                className: className,
                functionName: functionName,
                arguments: arguments
            );

            // Assert
            Assert.Equal(className, parameters.ClassName);
            Assert.Equal(functionName, parameters.FunctionName);
            Assert.Single(parameters.Arguments!);
            Assert.Equal("min", parameters.Arguments!["min"].Name);
        }
    }
}
