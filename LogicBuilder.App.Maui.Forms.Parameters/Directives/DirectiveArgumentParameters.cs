using LogicBuilder.Attributes;
using System;

namespace LogicBuilder.App.Maui.Forms.Parameters.Directives
{
    public class DirectiveArgumentParameters(
        [Comments("Name of the argument for the directive method.")]
        string name,

        [Comments("Value of the argument for the directive method.")]
        object value,

        [Comments("The argument type. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument (For literals, the full name (e.g. System.Int32) is sufficient.)")]
        Type type
    )
    {
        public string Name { get; } = name;
        public object Value { get; } = value;
        public Type Type { get; } = type;
    }
}