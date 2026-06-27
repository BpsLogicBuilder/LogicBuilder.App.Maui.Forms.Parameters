using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using LogicBuilder.Forms.Parameters.Expressions;
using System;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class MultiSelectFormControlSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "Courses";
            var keyFields = new List<string> { "CourseID" };
            string title = "Title";
            string placeholder = "(Title) required";
            string stringFormat = "{0}";
            Type type = typeof(List<int>);
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                "MultiSelectTemplate",
                "(Courses)",
                "Text",
                "Value",
                typeof(string),
                "Loading ...",
                new SelectorLambdaOperatorParameters(null!, null!, null!),
                new RequestDetailsParameters(null!, null!, null!, null!, null!)
            );
            var validationSetting = new FieldValidationSettingsParameters(null, null);
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";
            string? listElementTypeSource = "Contoso.Domain.Entities.Course";

            // Act
            var parameters = new MultiSelectFormControlSettingsParameters(
                field: field,
                keyFields: keyFields,
                title: title,
                placeholder: placeholder,
                stringFormat: stringFormat,
                type: type,
                multiSelectTemplate: multiSelectTemplate,
                validationSetting: validationSetting,
                fieldTypeSource: fieldTypeSource,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(type, parameters.Type);
            Assert.Equal(multiSelectTemplate, parameters.MultiSelectTemplate);
            Assert.Equal(validationSetting, parameters.ValidationSetting);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
            Assert.Equal(listElementTypeSource, parameters.ListElementTypeSource);
        }
    }
}
