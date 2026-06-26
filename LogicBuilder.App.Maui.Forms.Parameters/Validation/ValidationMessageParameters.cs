using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.Validation
{
    public class ValidationMessageParameters(
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. This property being validated.")]
        [NameValue(AttributeNames.USEFOREQUALITY, "true")]
        [NameValue(AttributeNames.USEFORHASHCODE, "true")]
        string field,

        [Comments("List of validation classes and messages to be used by the validatable view model.")]
        List<ValidationRuleParameters> rules,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>"
    )
    {
        public string Field { get; } = field;
        public List<ValidationRuleParameters> Rules { get; } = rules;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}