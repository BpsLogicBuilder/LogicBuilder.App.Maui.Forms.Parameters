using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.App.Maui.Forms.Parameters.Directives
{
    public class DirectiveParameters(
        [Comments("Details about the directive's function and its arguments.")]
        DirectiveDefinitionParameters definition,

        [Comments("Lambda expression which dynamically activates and desctivates the dependent function.")]
        FilterLambdaOperatorParameters condition
    )
    {
        public DirectiveDefinitionParameters Definition { get; } = definition;
        public FilterLambdaOperatorParameters Condition { get; } = condition;
    }
}