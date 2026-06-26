using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class TextFormSettingsParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Header field on the form")]
        string title,

        [Comments("List of sections on the form.  Each section includes a header and a collection of spans, links, labels or formatted labels.")]
        List<TextGroupParameters> textGroups
    )
    {
        public string Title { get; } = title;
        public List<TextGroupParameters> TextGroups { get; } = textGroups;
    }
}