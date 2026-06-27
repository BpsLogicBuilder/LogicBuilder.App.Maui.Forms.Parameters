using LogicBuilder.App.Maui.Forms.Parameters.Directives;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Directives
{
    public class VariableDirectivesParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "FirstName";
            var conditionalDirectives = new List<DirectiveParameters>
            {
                new(
                    new DirectiveDefinitionParameters("HideIf", "Check"),
                    new LogicBuilder.Forms.Parameters.Expressions.FilterLambdaOperatorParameters(null!, null!, null!)
                )
            };
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";

            // Act
            var parameters = new VariableDirectivesParameters(
                field: field,
                conditionalDirectives: conditionalDirectives,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(conditionalDirectives, parameters.ConditionalDirectives);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
