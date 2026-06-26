using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Attributes;
using System;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.DataForm
{
#pragma warning disable S107 //Parameters used to configure a control with several settings
    public class MultiSelectFormControlSettingsParameters(
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Source property name from the target object.")]
        string field,

        [Comments("Update listElementTypeSource first. Usually just a list of one item - the primary key. Additional fields apply when the primary key is a composite key.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(listElementTypeSource))]
        List<string> keyFields,

        [Comments("Label for the field.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        string title,

        [Comments("Place holder text.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "(Title) required")]
        string placeholder,

        [Comments("May need to remove (doubtful it is useful for a multiselect which has text display fields). String format - useful for binding decimals.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "{0}")]
        string stringFormat,

        [Comments("The type for the field being edited. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.  Use the full name (e.g. System.Int32) for literals or core platform types.")]
        Type type,

        [Comments("Holds the XAML template name for the field plus additional multi-select related properties (textField, valueField, request details etc.).")]
        MultiSelectTemplateParameters multiSelectTemplate,

        [Comments("Defines the field's default value, validation functions (and arguments for the validator where necessary).")]
        FieldValidationSettingsParameters? validationSetting = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>",

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? listElementTypeSource = "<myApp>.Domain.Entities.<EntityName>"
    ) : IFormItemSettingsParameters
#pragma warning restore S107
    {
        public List<string> KeyFields { get; } = keyFields;
        public string Field { get; } = field;
        public string Title { get; } = title;
        public string Placeholder { get; } = placeholder;
        public string StringFormat { get; } = stringFormat;
        public Type Type { get; } = type;
        public MultiSelectTemplateParameters MultiSelectTemplate { get; } = multiSelectTemplate;
        public FieldValidationSettingsParameters? ValidationSetting { get; } = validationSetting;
        public string? FieldTypeSource { get; } = fieldTypeSource;
        public string? ListElementTypeSource { get; } = listElementTypeSource;
    }
}