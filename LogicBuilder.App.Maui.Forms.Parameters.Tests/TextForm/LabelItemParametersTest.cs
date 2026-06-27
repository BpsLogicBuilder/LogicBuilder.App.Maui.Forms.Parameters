using LogicBuilder.App.Maui.Forms.Parameters.TextForm;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.TextForm
{
    public class LabelItemParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string text = "Label text";

            // Act
            var parameters = new LabelItemParameters(
                text: text
            );

            // Assert
            Assert.Equal(text, parameters.Text);
        }
    }
}
