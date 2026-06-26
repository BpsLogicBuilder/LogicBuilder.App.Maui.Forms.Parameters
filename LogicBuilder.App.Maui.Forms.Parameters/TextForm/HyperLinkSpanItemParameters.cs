using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class HyperLinkSpanItemParameters(
        [Comments("Text section of hyperlink span.")]
        string text,

        [Comments("URL section of hyperlink span.")]
        string url
    ) : ISpanItemParameters
    {
        public string Text { get; } = text;
        public string Url { get; } = url;
    }
}