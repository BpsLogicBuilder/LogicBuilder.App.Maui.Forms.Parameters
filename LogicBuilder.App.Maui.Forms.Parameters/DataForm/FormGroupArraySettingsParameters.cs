using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Maui.Forms.Parameters.DataForm
{
#pragma warning disable S107 //Parameters used to configure a form array with several settings
    public class FormGroupArraySettingsParameters(
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        [Comments("Update fieldTypeSource first. Source property name from the target object.")]
        string field,

        [Comments("Update listElementTypeSource first. Usually just a list of one item - the primary key. Additional fields apply when the primary key is a composite key.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(listElementTypeSource))]
        List<string> keyFields,

        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Title for the form group.")]
        string title,

        [NameValue(AttributeNames.DEFAULTVALUE, "(Form Collection)")]
        [Comments("e.g. (Addresses). Placeholder text for the for multi-form control on the parent form.")]
        string placeholder,

        [Comments("e.g. T. The element type for the list being edited. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type modelType,

        [Comments("e.g. ICollection<T>. The type for the list being edited. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type type,

        [NameValue(AttributeNames.DEFAULTVALUE, "(Form)")]
        [Comments("Placeholder text for the for control when the form is a one-to-one form field.")]
        string validFormControlText,

        [NameValue(AttributeNames.DEFAULTVALUE, "(Invalid Form)")]
        [Comments("Placeholder text for the for control when the form is a one-to-one form field and the form is invalid.")]
        string invalidFormControlText,

        [Comments("Template and property bindings to be displayed for each item in the list.")]
        FormsCollectionDisplayTemplateParameters formsCollectionDisplayTemplate,

        [Comments("XAML template for the form group.")]
        FormGroupTemplateParameters formGroupTemplate,

        [Comments("Configuration for each field in one of the array's form groups.")]
        List<IFormItemSettingsParameters> fieldSettings,

        [Comments("Input validation messages for each field.")]
        List<ValidationMessageParameters> validationMessages,

        [Comments("Conditional directtives for each field.")]
        List<VariableDirectivesParameters>? conditionalDirectives = null,

        [Comments("Multibindings list for the form header field.")]
        MultiBindingParameters? headerBindings = null,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = "<myApp>.Domain.Entities.<EntityName>",

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [Comments("Fully qualified class name for the element type.")]
        string? listElementTypeSource = "Contoso.Domain.Entities"
    ) : IFormItemSettingsParameters
#pragma warning restore S107
    {
        public string Field { get; } = field;
        public string Title { get; } = title;
        public string Placeholder { get; } = placeholder;
        public Type ModelType { get; } = modelType;
        public Type Type { get; } = type;
        public string ValidFormControlText { get; } = validFormControlText;
        public string InvalidFormControlText { get; } = invalidFormControlText;
        public List<string> KeyFields { get; } = keyFields;
        public FormsCollectionDisplayTemplateParameters FormsCollectionDisplayTemplate { get; } = formsCollectionDisplayTemplate;
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
        public string? ListElementTypeSource { get; } = listElementTypeSource;
    }
}