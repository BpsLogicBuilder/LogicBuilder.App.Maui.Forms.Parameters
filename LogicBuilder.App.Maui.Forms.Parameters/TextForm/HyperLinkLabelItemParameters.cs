using LogicBuilder.Attributes;

namespace LogicBuilder.App.Maui.Forms.Parameters.TextForm
{
    public class HyperLinkLabelItemParameters(
        [Comments("Text section of hyperlink label.")]
        string text,

        [Comments("URL section of hyperlink label.")]
        string url
    ) : ILabelItemParameters
    {
        public string Text { get; } = text;
        public string Url { get; } = url;
    }
}