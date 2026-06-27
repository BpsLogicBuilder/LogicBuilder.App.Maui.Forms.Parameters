using LogicBuilder.App.Maui.Forms.Parameters.TextForm;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.TextForm
{
    public class HyperLinkSpanItemParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string text = "Link text";
            string url = "http://example.com";

            // Act
            var parameters = new HyperLinkSpanItemParameters(
                text: text,
                url: url
            );

            // Assert
            Assert.Equal(text, parameters.Text);
            Assert.Equal(url, parameters.Url);
        }
    }
}
