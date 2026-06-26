using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Maui.Forms.Parameters.Directives
{
    public class DirectiveDefinitionParameters(
        [Comments("Class name for the directive.")]
        [Domain("DisableIf,HideIf,ValidateIf")]
        [NameValue(AttributeNames.DEFAULTVALUE, "HideIf")]
        string className,

        [Comments("Function name.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Check")]
        [Domain("Check")]
        string functionName,

        [Comments("Where applicable, add arguments for the directive evaluation function.")]
        List<DirectiveArgumentParameters>? arguments = null
    )
    {
        public string ClassName { get; } = className;
        public string FunctionName { get; } = functionName;
        public Dictionary<string, DirectiveArgumentParameters>? Arguments { get; } = arguments?.ToDictionary(arg => arg.Name);
    }
}