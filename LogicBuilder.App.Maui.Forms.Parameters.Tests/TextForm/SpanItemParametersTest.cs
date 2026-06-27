using LogicBuilder.App.Maui.Forms.Parameters.TextForm;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.TextForm
{
    public class SpanItemParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string text = "Span text";

            // Act
            var parameters = new SpanItemParameters(
                text: text
            );

            // Assert
            Assert.Equal(text, parameters.Text);
        }
    }
}
