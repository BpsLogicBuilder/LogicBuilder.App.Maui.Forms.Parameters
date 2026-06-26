using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
    public class TextFieldTemplateParameters(
        [Comments("XAML template name for the field.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "TextTemplate")]
        [Domain("TextTemplate,CheckboxTemplate,DateTemplate,PasswordTemplate,HiddenTemplate,LabelTemplate,SwitchTemplate")]
        string templateName
    )
    {
        public string TemplateName { get; } = templateName;
    }
}