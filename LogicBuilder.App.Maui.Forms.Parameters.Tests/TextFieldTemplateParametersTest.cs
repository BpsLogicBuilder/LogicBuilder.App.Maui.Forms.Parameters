using LogicBuilder.App.Maui.Forms.Parameters;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class TextFieldTemplateParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string templateName = "TextTemplate";

            // Act
            var parameters = new TextFieldTemplateParameters(
                templateName: templateName
            );

            // Assert
            Assert.Equal(templateName, parameters.TemplateName);
        }
    }
}
