using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Attributes;
using System;

namespace LogicBuilder.App.Maui.Forms.Parameters.DataForm
{
#pragma warning disable S107 //Parameters used to configure a control with several settings
    public class InputFieldControlSettingsParameters(
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. This property being edited.")]
        string field,

        [Comments("Label for the field.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        string title,

        [Comments("Place holder text.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "(Title) required")]
        string placeholder,

        [Comments("String format - useful for binding decimals.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "{0}")]
        string stringFormat,

        [Comments("The type for the field being edited. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.  Use the full name (e.g. System.Int32) for literals or core platform types.")]
        Type type,

        [Comments("Holds the XAML template name for the field.")]
        TextFieldTemplateParameters textTemplate,

        [Comments("Useful when we need one template in edit mode and a different one in add mode.  Holds the XAML template name for the field.")]
        TextFieldTemplateParameters? updateOnlytextTemplate = null,

        [Comments("Defines the field's default value, validation functions (and arguments for the validator where necessary).")]
        FieldValidationSettingsParameters? validationSetting = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>"
    ) : IFormItemSettingsParameters
#pragma warning restore S107
    {
        public string Field { get; } = field;
        public string Title { get; } = title;
        public string Placeholder { get; } = placeholder;
        public string StringFormat { get; } = stringFormat;
        public Type Type { get; } = type;
        public TextFieldTemplateParameters TextTemplate { get; } = textTemplate;
        public TextFieldTemplateParameters? UpdateOnlyTextTemplate { get; } = updateOnlytextTemplate;
        public FieldValidationSettingsParameters? ValidationSetting { get; } = validationSetting;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}
