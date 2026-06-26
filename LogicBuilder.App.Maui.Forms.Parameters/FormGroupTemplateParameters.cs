using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
    public class FormGroupTemplateParameters(
        [Comments("XAML template name for the form field.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "PopupFormGroupTemplate")]
        [Domain("InlineFormGroupTemplate,PopupFormGroupTemplate")]
        string templateName
    )
    {
        public string TemplateName { get; } = templateName;
    }
}