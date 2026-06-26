using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class FormattedLabelItemParameters(
        [Comments("List of text and hyperlink items which combine to form the formatted label.")]
        List<ISpanItemParameters> items
    ) : ILabelItemParameters
    {
        public List<ISpanItemParameters> Items { get; } = items;
    }
}