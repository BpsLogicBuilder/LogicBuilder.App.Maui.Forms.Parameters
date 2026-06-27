using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class FormGroupBoxSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string groupHeader = "Header";
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            bool isHidden = false;

            // Act
            var parameters = new FormGroupBoxSettingsParameters(
                groupHeader: groupHeader,
                fieldSettings: fieldSettings,
                headerBindings: headerBindings,
                isHidden: isHidden
            );

            // Assert
            Assert.Equal(groupHeader, parameters.GroupHeader);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(isHidden, parameters.IsHidden);
        }

        [Fact]
        public void ConstructorThrowArgumentExceptionWhenFieldSettingIsFormGroupBoxSettingsParameters()
        {
            // Arrange
            string groupHeader = "Header";
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new FormGroupBoxSettingsParameters("Field1", [], new MultiBindingParameters("{0}", ["Field1"]), false)
            };
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            bool isHidden = false;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new FormGroupBoxSettingsParameters(
                groupHeader: groupHeader,
                fieldSettings: fieldSettings,
                headerBindings: headerBindings,
                isHidden: isHidden
            ));
        }
    }
}
