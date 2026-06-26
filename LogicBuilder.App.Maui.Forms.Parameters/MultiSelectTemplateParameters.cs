using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
#pragma warning disable S107 //Parameters used to configure a control with several settings
    public class MultiSelectTemplateParameters(
        [Comments("XAML template for the control.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "MultiSelectTemplate")]
        string templateName,

        [Comments("Placeholder text.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "(Courses)")]
        string placeholderText,

        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Property name for the text field.")]
        string textField,

        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Property name for the value field.")]
        string valueField,

        [Comments("The model element type for the muli-select list. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type modelType,

        [Comments("Loading text is useful when the cache has expired and the items source is being retrieved.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Loading ...")]
        string loadingIndicatorText,

        [Comments("Single object used for defining the selector lambda expression e.g. q => q.OrderBy(s => s.FullName).Select(a => new InstructorModel() {ID = a.ID, FullName = a.FullName})")]
        SelectorLambdaOperatorParameters textAndValueSelector,

        [Comments("Includes the source URL. May specify model and data types if we use the URL for multiple types.")]
        RequestDetailsParameters requestDetails,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>"
    )
#pragma warning restore S107
    {
        public string TemplateName { get; } = templateName;
        public string PlaceholderText { get; } = placeholderText;
        public string TextField { get; } = textField;
        public string ValueField { get; } = valueField;
        public Type ModelType { get; } = modelType;
        public string LoadingIndicatorText { get; } = loadingIndicatorText;
        public SelectorLambdaOperatorParameters TextAndValueSelector { get; } = textAndValueSelector;
        public RequestDetailsParameters RequestDetails { get; } = requestDetails; 
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}