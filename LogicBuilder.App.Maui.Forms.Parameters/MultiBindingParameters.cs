using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
    public class MultiBindingParameters(
        [Comments("Specify a format for the multi binding e.g. 'Value: {0:F2} {1}'")]
        [NameValue(AttributeNames.DEFAULTVALUE, "{0}")]
        string stringFormat,

        [Comments("The list of fields to be bound in the multibinding.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        List<string> fields,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = null
    )
    {
        public string StringFormat { get; } = stringFormat;
        public List<string> Fields { get; } = fields;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}