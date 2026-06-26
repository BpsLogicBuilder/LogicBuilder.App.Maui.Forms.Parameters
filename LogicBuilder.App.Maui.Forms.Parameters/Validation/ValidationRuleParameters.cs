using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.Validation
{
    public class ValidationRuleParameters(
            [NameValue(AttributeNames.DEFAULTVALUE, "RequiredRule")]
            [Comments("The validation class")]
            [Domain("IsLengthValidRule,IsMatchRule,IsPatternMatchRule,IsValidEmailRule,IsValidPasswordRule,IsValueTrueRule,MustBeIntegerRule,MustBeNumberRule,MustBePositiveNumberRule,RangeRule,RequiredRule,AtLeastOneRequiredRule")]
            string className,

            [Comments("The validtion message")]
            [NameValue(AttributeNames.DEFAULTVALUE, "(Property) is required.")]
            string message
        )
    {
        public string ClassName { get; } = className;
        public string Message { get; } = message;
    }
}