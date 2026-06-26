using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Maui.Forms.Parameters.DataForm
{
#pragma warning disable S107 //Parameters used to configure a form with several settings
    public class DataFormSettingsParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header field on the form")]
        string title,

        [Comments("Input validation messages for each field.")]
        List<ValidationMessageParameters> validationMessages,

        [Comments("List of fields and form groups for this form.")]
        List<IFormItemSettingsParameters> fieldSettings,

        [Comments("Click the Variable button and select the configured FormType enum field.")]
        FormType formType,

        [Comments("The model type for the object being edited. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type modelType,

        [Comments("Multibindings list for the form header field - typically used in edit mode.")]
        MultiBindingParameters? headerBindings = null,

        [Comments("Includes the URL's for create, read, and update.")]
        FormRequestDetailsParameters? requestDetails = null,

        [Comments("Conditional directtives for each field.")]
        List<VariableDirectivesParameters>? conditionalDirectives = null,

        [Comments("Multibindings list for the form header field.")]
        MultiBindingParameters? subtitleBindings = null
    )
#pragma warning restore S107
    {
        public string Title { get; } = title;
        public Dictionary<string, List<ValidationRuleParameters>> ValidationMessages { get; } = validationMessages.ToDictionary
        (
            vm => vm.Field,
            vm => vm.Rules ?? []
        );
        public List<IFormItemSettingsParameters> FieldSettings { get; } = fieldSettings;
        public FormType FormType { get; } = formType;
        public Type ModelType { get; } = modelType;
        public MultiBindingParameters? HeaderBindings { get; } = headerBindings;
        public FormRequestDetailsParameters? RequestDetails { get; } = requestDetails;
        public Dictionary<string, List<DirectiveParameters>>? ConditionalDirectives { get; } = conditionalDirectives?.ToDictionary
        (
            cd => cd.Field,
            cd => cd.ConditionalDirectives ?? []
        );
        public MultiBindingParameters? SubtitleBindings { get; } = subtitleBindings;
    }
}