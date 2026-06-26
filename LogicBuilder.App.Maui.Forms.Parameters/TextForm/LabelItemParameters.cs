using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class LabelItemParameters(
            [Comments("Label text.")]
            string text
        ) : ILabelItemParameters
    {
        public string Text { get; } = text;
    }
}