using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using LogicBuilder.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
    public class FormsCollectionDisplayTemplateParameters(
        [Comments("XAML template name for the collection view item template.")]
        [Domain("HeaderTextDetailTemplate, TextDetailTemplate")]
        [NameValue(AttributeNames.DEFAULTVALUE, "HeaderTextDetailTemplate")]
        string templateName,

        [Comments("Defines which of the model type fields bind to the named template fields (e.g. Header, Text, Detail).")]
        List<ItemBindingParameters> bindings
    )
    {
        public string TemplateName { get; } = templateName;
        public Dictionary<string, ItemBindingParameters> Bindings { get; } = bindings.ToDictionary(cvib => cvib.Name);
    }
}