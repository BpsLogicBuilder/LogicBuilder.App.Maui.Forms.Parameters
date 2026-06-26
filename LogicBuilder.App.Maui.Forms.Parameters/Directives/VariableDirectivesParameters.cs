using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.Directives
{
    public class VariableDirectivesParameters(
        [Comments("Update fieldTypeSource first. The property to which the directive applies.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        string field,

        [Comments("List of object which define the directive including functions/expressions for enabling/disabling the directive.")]
        List<DirectiveParameters> conditionalDirectives,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "<myApp>.Domain.Entities.<EntityName>")]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = null
    )
    {
        public string Field { get; } = field;
        public List<DirectiveParameters> ConditionalDirectives { get; } = conditionalDirectives;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}