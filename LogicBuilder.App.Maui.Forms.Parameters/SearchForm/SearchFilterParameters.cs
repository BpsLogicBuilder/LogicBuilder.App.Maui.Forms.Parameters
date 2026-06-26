using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.SearchForm
{
    public class SearchFilterParameters(
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
            [Comments("Update fieldTypeSource first. This property being searched.")]
            string field,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [Comments("Fully qualified class name for the model type.")]
            string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>"
        ) : ISearchFilterParameters
    {
        public string Field { get; } = field;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}