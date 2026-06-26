using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.Bindings
{
	abstract public class ItemBindingParameters(
        [Comments("The section of the item template we're binding the property to.")]
        [Domain("Header,Text,Detail")]
        [NameValue(AttributeNames.USEFOREQUALITY, "true")]
        [NameValue(AttributeNames.USEFORHASHCODE, "true")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Header")]
        string name,

        [Comments("Update fieldTypeSource first. The property to bind to the name section.")]
        [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
        [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, nameof(fieldTypeSource))]
        string property,

        [Comments("Label for the field.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        string title,

        [Comments("Specify a format for the binding e.g. 'Value: {0:F2}'")]
        [NameValue(AttributeNames.DEFAULTVALUE, "{0}")]
        string stringFormat,

        [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
        [NameValue(AttributeNames.DEFAULTVALUE, "Contoso.Domain.Entities")]
        [Comments("Fully qualified class name for the model type.")]
        string? fieldTypeSource = null
    )
    {
        public string Name { get; } = name;
        public string Property { get; } = property;
        public string Title { get; } = title;
        public string StringFormat { get; } = stringFormat;
        public string? FieldTypeSource { get; } = fieldTypeSource;
    }
}