using LogicBuilder.App.Maui.Forms.Parameters.TextForm;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.TextForm
{
    public class TextGroupParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string title = "Title";
            var labels = new List<ILabelItemParameters>
            {
                new LabelItemParameters("Label text")
            };

            // Act
            var parameters = new TextGroupParameters(
                title: title,
                labels: labels
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Equal(labels, parameters.Labels);
        }
    }
}
