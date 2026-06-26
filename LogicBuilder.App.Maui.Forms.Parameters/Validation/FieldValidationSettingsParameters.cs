using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.Validation
{
    public class FieldValidationSettingsParameters(
        [Comments("Default value for the form control.")]
        object? defaultValue = null,

        [Comments("Confifuration for validation classes, functions (and arguments for the validator where necessary).")]
        List<ValidatorDefinitionParameters>? validators = null
    )
    {
        public object? DefaultValue { get; } = defaultValue;
        public List<ValidatorDefinitionParameters>? Validators { get; } = validators;
    }
}