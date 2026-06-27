using LogicBuilder.App.Maui.Forms.Parameters;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class FormGroupTemplateParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string templateName = "PopupFormGroupTemplate";

            // Act
            var parameters = new FormGroupTemplateParameters(
                templateName: templateName
            );

            // Assert
            Assert.Equal(templateName, parameters.TemplateName);
        }
    }
}
