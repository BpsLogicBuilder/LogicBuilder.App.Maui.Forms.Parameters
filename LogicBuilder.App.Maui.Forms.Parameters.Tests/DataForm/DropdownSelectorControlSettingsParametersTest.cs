using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Forms.Parameters.Expressions;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class DropdownSelectorControlSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "DepartmentID";
            string title = "Title";
            string placeholder = "(Title) required";
            string stringFormat = "{0}";
            Type type = typeof(int);
            var dropDownTemplate = new DropDownTemplateParameters(
                "PickerTemplate",
                "Select Item",
                "Text",
                "Value",
                "Loading ...",
                new SelectorLambdaOperatorParameters(null!, null!, null!),
                new RequestDetailsParameters(null!, null!, null!, null!, null!)
            );
            var validationSetting = new FieldValidationSettingsParameters(null, null);
            string? fieldTypeSource = "Contoso.Domain.Entities";

            // Act
            var parameters = new DropdownSelectorControlSettingsParameters(
                field: field,
                title: title,
                placeholder: placeholder,
                stringFormat: stringFormat,
                type: type,
                dropDownTemplate: dropDownTemplate,
                validationSetting: validationSetting,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(type, parameters.Type);
            Assert.Equal(dropDownTemplate, parameters.DropDownTemplate);
            Assert.Equal(validationSetting, parameters.ValidationSetting);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
