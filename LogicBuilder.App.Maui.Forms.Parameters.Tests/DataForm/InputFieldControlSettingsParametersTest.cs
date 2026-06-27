using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class InputFieldControlSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "FirstName";
            string title = "Title";
            string placeholder = "(Title) required";
            string stringFormat = "{0}";
            Type type = typeof(string);
            var textTemplate = new TextFieldTemplateParameters("TextTemplate");
            var updateOnlytextTemplate = new TextFieldTemplateParameters("LabelTemplate");
            var validationSetting = new FieldValidationSettingsParameters(null, null);
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";

            // Act
            var parameters = new InputFieldControlSettingsParameters(
                field: field,
                title: title,
                placeholder: placeholder,
                stringFormat: stringFormat,
                type: type,
                textTemplate: textTemplate,
                updateOnlytextTemplate: updateOnlytextTemplate,
                validationSetting: validationSetting,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(type, parameters.Type);
            Assert.Equal(textTemplate, parameters.TextTemplate);
            Assert.Equal(updateOnlytextTemplate, parameters.UpdateOnlyTextTemplate);
            Assert.Equal(validationSetting, parameters.ValidationSetting);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
