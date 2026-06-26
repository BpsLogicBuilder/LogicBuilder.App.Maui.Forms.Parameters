using LogicBuilder.Attributes;
using System;

namespace LogicBuilder.App.Maui.Forms.Parameters.Validation
{
    public class ValidatorArgumentParameters(
        [Comments("The argument's name.")]
        [NameValue(AttributeNames.USEFOREQUALITY, "true")]
        [NameValue(AttributeNames.USEFORHASHCODE, "true")]
        string name,

        [Comments("The argument's value.")]
        [NameValue(AttributeNames.USEFOREQUALITY, "false")]
        [NameValue(AttributeNames.USEFORHASHCODE, "false")]
        object value,

        [Comments("The argumet type. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.  Use the full name (e.g. System.Int32) for literals or core platform types.")]
        Type type
    )
    {
        public string Name { get; } = name;
        public object Value { get; } = value;
        public Type Type { get; } = type;
    }
}