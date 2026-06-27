using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class FormsCollectionDisplayTemplateParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string templateName = "HeaderTextDetailTemplate";
            var bindings = new List<ItemBindingParameters>
            {
                new TextItemBindingParameters("Header", "Name", "Header Text", "{0}", new TextFieldTemplateParameters("TextTemplate")),
                new TextItemBindingParameters("Text", "Description", "Description Text", "{0}", new TextFieldTemplateParameters("TextTemplate"))
            };

            // Act
            var parameters = new FormsCollectionDisplayTemplateParameters(
                templateName: templateName,
                bindings: bindings
            );

            // Assert
            Assert.Equal(templateName, parameters.TemplateName);
            Assert.Equal(2, parameters.Bindings.Count);
            Assert.Equal(bindings[0].Name, parameters.Bindings["Header"].Name);
            Assert.Equal(bindings[1].Name, parameters.Bindings["Text"].Name);
        }
    }
}
