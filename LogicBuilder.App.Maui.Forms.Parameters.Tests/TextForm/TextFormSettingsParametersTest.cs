using LogicBuilder.App.Maui.Forms.Parameters.TextForm;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.TextForm
{
    public class TextFormSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string title = "Title";
            var textGroups = new List<TextGroupParameters>
            {
                new("Group 1", [])
            };

            // Act
            var parameters = new TextFormSettingsParameters(
                title: title,
                textGroups: textGroups
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Equal(textGroups, parameters.TextGroups);
        }
    }
}
