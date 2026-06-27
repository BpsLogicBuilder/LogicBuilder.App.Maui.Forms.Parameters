using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Bindings
{
    public class TextItemBindingParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string name = "Header";
            string property = "FirstName";
            string title = "First Name";
            string stringFormat = "{0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "TextTemplate");
            string fieldTypeSource = "Contoso.Domain.Entities.Person";

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(property, parameters.Property);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(textTemplate, parameters.TextTemplate);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeWithNullFieldTypeSource()
        {
            // Arrange
            string name = "Text";
            string property = "LastName";
            string title = "Last Name";
            string stringFormat = "Name: {0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "TextTemplate");

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(property, parameters.Property);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(textTemplate, parameters.TextTemplate);
            Assert.Null(parameters.FieldTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeWithDifferentTemplateTypes()
        {
            // Arrange
            string name = "Detail";
            string property = "Email";
            string title = "Email Address";
            string stringFormat = "{0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "PasswordTemplate");
            string fieldTypeSource = "Contoso.Domain.Entities.User";

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal("PasswordTemplate", parameters.TextTemplate.TemplateName);
        }

        [Fact]
        public void ConstructorShouldInitializeWithDateTemplate()
        {
            // Arrange
            string name = "Header";
            string property = "BirthDate";
            string title = "Birth Date";
            string stringFormat = "{0:MM/dd/yyyy}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "DateTemplate");
            string fieldTypeSource = "Contoso.Domain.Entities.Person";

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal("DateTemplate", parameters.TextTemplate.TemplateName);
            Assert.Equal("{0:MM/dd/yyyy}", parameters.StringFormat);
        }

        [Fact]
        public void ConstructorShouldInitializeWithCheckboxTemplate()
        {
            // Arrange
            string name = "Text";
            string property = "IsActive";
            string title = "Active";
            string stringFormat = "{0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "CheckboxTemplate");
            string fieldTypeSource = "Contoso.Domain.Entities.Employee";

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal("CheckboxTemplate", parameters.TextTemplate.TemplateName);
        }

        [Fact]
        public void ConstructorShouldInitializeWithSwitchTemplate()
        {
            // Arrange
            string name = "Detail";
            string property = "IsEnabled";
            string title = "Enabled";
            string stringFormat = "{0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "SwitchTemplate");
            string fieldTypeSource = "Enrollment.Domain.Entities.Configuration";

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal("SwitchTemplate", parameters.TextTemplate.TemplateName);
        }

        [Fact]
        public void ConstructorShouldInitializeWithLabelTemplate()
        {
            // Arrange
            string name = "Header";
            string property = "DisplayName";
            string title = "Display Name";
            string stringFormat = "{0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "LabelTemplate");
            string fieldTypeSource = "Enrollment.Domain.Entities.Student";

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal("LabelTemplate", parameters.TextTemplate.TemplateName);
        }

        [Fact]
        public void ConstructorShouldInitializeWithHiddenTemplate()
        {
            // Arrange
            string name = "Text";
            string property = "InternalId";
            string title = "Internal ID";
            string stringFormat = "{0}";
            var textTemplate = new TextFieldTemplateParameters(templateName: "HiddenTemplate");

            // Act
            var parameters = new TextItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                textTemplate: textTemplate
            );

            // Assert
            Assert.Equal("HiddenTemplate", parameters.TextTemplate.TemplateName);
            Assert.Null(parameters.FieldTypeSource);
        }
    }
}