using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class SpanItemParameters(
            [Comments("Span text.")]
            string text
        ) : ISpanItemParameters
    {
        public string Text { get; } = text;
    }
}