using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
#pragma warning disable S107 //Parameters used to configure a control with several settings
    public class DropDownTemplateParameters(
        [Comments("XAML template for the picker.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "PickerTemplate")]
        string templateName,

        [Comments("Title text.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Select (Entity)")]
        string titleText,

        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Property name for the text field.")]
        string textField,

        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Property name for the value field.")]
        string valueField,

        [Comments("Loading text is useful when the cache has expired and the items source is being retrieved.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Loading ...")]
        string loadingIndicatorText,

        [Comments("Single object used for defining the selector lambda expression e.g. q => q.OrderBy(s => s.FullName).Select(a => new InstructorModel() {ID = a.ID, FullName = a.FullName})")]
        SelectorLambdaOperatorParameters textAndValueSelector,

        [Comments("Includes the source URL. May specify model and data types if we use the URL for multiple types.")]
        RequestDetailsParameters requestDetails,

        [Comments("Used the dropdown or multiselect items change conditionally at runtime.  Add a flow module to define a new selector (SelectorLambdaOperatorParameters) at run time.  Set reloadItemsFlowName to the flow name.")]
        string? reloadItemsFlowName = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>"
    )
#pragma warning restore S107
    {
        public string TemplateName { get; } = templateName;
        public string TitleText { get; } = titleText;
        public string TextField { get; } = textField;
        public string ValueField { get; } = valueField;
        public string LoadingIndicatorText { get; } = loadingIndicatorText;
        public SelectorLambdaOperatorParameters TextAndValueSelector { get; } = textAndValueSelector;
        public RequestDetailsParameters RequestDetails { get; } = requestDetails;
        public string? ReloadItemsFlowName { get; } = reloadItemsFlowName;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}