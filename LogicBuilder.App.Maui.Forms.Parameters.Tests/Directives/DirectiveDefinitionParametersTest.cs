using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Directives
{
    public class DirectiveDefinitionParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string className = "HideIf";
            string functionName = "Check";
            var arguments = new List<DirectiveArgumentParameters>
            {
                new("arg1", "value1", typeof(string))
            };

            // Act
            var parameters = new DirectiveDefinitionParameters(
                className: className,
                functionName: functionName,
                arguments: arguments
            );

            // Assert
            Assert.Equal(className, parameters.ClassName);
            Assert.Equal(functionName, parameters.FunctionName);
            Assert.Single(parameters.Arguments!);
            Assert.Equal("arg1", parameters.Arguments!["arg1"].Name);
        }
    }
}
