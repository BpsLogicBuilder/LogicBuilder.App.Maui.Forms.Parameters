using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Maui.Forms.Parameters.DataForm
{
#pragma warning disable S107 //Parameters used to configure a form group with several settings
    public class FormGroupSettingsParameters(
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Source property name from the target object.")]
        string field,

        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Title for the form group.")]
        string title,

        [NameValue(AttributeNames.DEFAULTVALUE, "(Form)")]
        [Comments("Placeholder text for the for control when the form is a one-to-one form field. May need to remove this for form arrays..")]
        string validFormControlText,

        [NameValue(AttributeNames.DEFAULTVALUE, "(Invalid Form)")]
        [Comments("Placeholder text for the for control when the form is a one-to-one form field and the form is invalid. May need to remove this for form arrays..")]
        string invalidFormControlText,

        [Comments("Place holder text.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "(Property name)")]
        string placeholder,

        [Comments("The entity type for the object being edited. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type modelType,

        [Comments("XAML template for the form group.")]
        FormGroupTemplateParameters formGroupTemplate,

        [Comments("Configuration for each field in the form group.")]
        List<IFormItemSettingsParameters> fieldSettings,

        [Comments("Input validation messages for each field.")]
        List<ValidationMessageParameters> validationMessages,

        [Comments("Conditional directtives for each field.")]
        List<VariableDirectivesParameters>? conditionalDirectives = null,

        [Comments("Multibindings list for the form header field.")]
        MultiBindingParameters? headerBindings = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>"
    ) : IFormItemSettingsParameters
#pragma warning restore S107
    {
        public string Field { get; } = field;
        public string Title { get; } = title;
        public string ValidFormControlText { get; } = validFormControlText;
        public string InvalidFormControlText { get; } = invalidFormControlText;
        public string Placeholder { get; } = placeholder;
        public Type ModelType { get; } = modelType;
        public FormGroupTemplateParameters FormGroupTemplate { get; } = formGroupTemplate;
        public List<IFormItemSettingsParameters> FieldSettings { get; } = fieldSettings;
        public Dictionary<string, List<ValidationRuleParameters>> ValidationMessages { get; } = validationMessages.ToDictionary
            (
                vm => vm.Field,
                vm => vm.Rules ?? []
            );
        public Dictionary<string, List<DirectiveParameters>>? ConditionalDirectives { get; } = conditionalDirectives?.ToDictionary
            (
                cd => cd.Field,
                cd => cd.ConditionalDirectives ?? []
            );
        public MultiBindingParameters? HeaderBindings { get; } = headerBindings;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}