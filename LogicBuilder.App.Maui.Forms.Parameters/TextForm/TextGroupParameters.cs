using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class TextGroupParameters(
        [NameValue(AttributeNames.DEFAULTVALUE, "Title")]
        [Comments("Group header text for a group on the form")]
        string title,

        [Comments("Collection of spans, links, labels or formatted labels for this group.")]
        List<ILabelItemParameters> labels
    )
    {
        public string Title { get; } = title;
        public List<ILabelItemParameters> Labels { get; } = labels;
    }
}