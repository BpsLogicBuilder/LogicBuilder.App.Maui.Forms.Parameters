using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Directives
{
    public class DirectiveParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            var definition = new DirectiveDefinitionParameters("HideIf", "Check");
            var condition = new FilterLambdaOperatorParameters(null!, null!, null!);

            // Act
            var parameters = new DirectiveParameters(
                definition: definition,
                condition: condition
            );

            // Assert
            Assert.Equal(definition, parameters.Definition);
            Assert.Equal(condition, parameters.Condition);
        }
    }
}
