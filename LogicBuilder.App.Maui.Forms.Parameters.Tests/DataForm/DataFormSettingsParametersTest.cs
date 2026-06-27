using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class DataFormSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string title = "Title";
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Field1", [])
            };
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            FormType formType = FormType.Add;
            Type modelType = typeof(string);
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            var requestDetails = new FormRequestDetailsParameters("getUrl", "addUrl", "updateUrl", "deleteUrl", typeof(string), typeof(int));
            var conditionalDirectives = new List<VariableDirectivesParameters>
            {
                new("Field1", [])
            };
            var subtitleBindings = new MultiBindingParameters("{0}", ["Field2"]);

            // Act
            var parameters = new DataFormSettingsParameters(
                title: title,
                validationMessages: validationMessages,
                fieldSettings: fieldSettings,
                formType: formType,
                modelType: modelType,
                headerBindings: headerBindings,
                requestDetails: requestDetails,
                conditionalDirectives: conditionalDirectives,
                subtitleBindings: subtitleBindings
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Single(parameters.ValidationMessages);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal(formType, parameters.FormType);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Single(parameters.ConditionalDirectives!);
            Assert.Equal(subtitleBindings, parameters.SubtitleBindings);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenValidationMessagesOrDirectivesHaveFieldsWithNullValues()
        {
            // Arrange
            string title = "Title";
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Field1", null!)
            };
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            FormType formType = FormType.Add;
            Type modelType = typeof(string);
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            var requestDetails = new FormRequestDetailsParameters("getUrl", "addUrl", "updateUrl", "deleteUrl", typeof(string), typeof(int));
            var conditionalDirectives = new List<VariableDirectivesParameters>
            {
                new("Field1", null!)
            };
            var subtitleBindings = new MultiBindingParameters("{0}", ["Field2"]);

            // Act
            var parameters = new DataFormSettingsParameters(
                title: title,
                validationMessages: validationMessages,
                fieldSettings: fieldSettings,
                formType: formType,
                modelType: modelType,
                headerBindings: headerBindings,
                requestDetails: requestDetails,
                conditionalDirectives: conditionalDirectives,
                subtitleBindings: subtitleBindings
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Single(parameters.ValidationMessages);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal(formType, parameters.FormType);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Single(parameters.ConditionalDirectives!);
            Assert.Equal(subtitleBindings, parameters.SubtitleBindings);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenConditionalDirectivesIsNull()
        {
            // Arrange
            string title = "Title";
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Field1", [])
            };
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            FormType formType = FormType.Add;
            Type modelType = typeof(string);
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            var requestDetails = new FormRequestDetailsParameters("getUrl", "addUrl", "updateUrl", "deleteUrl", typeof(string), typeof(int));

            var subtitleBindings = new MultiBindingParameters("{0}", ["Field2"]);

            // Act
            var parameters = new DataFormSettingsParameters(
                title: title,
                validationMessages: validationMessages,
                fieldSettings: fieldSettings,
                formType: formType,
                modelType: modelType,
                headerBindings: headerBindings,
                requestDetails: requestDetails,
                conditionalDirectives: null,
                subtitleBindings: subtitleBindings
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Single(parameters.ValidationMessages);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Equal(formType, parameters.FormType);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Null(parameters.ConditionalDirectives);
            Assert.Equal(subtitleBindings, parameters.SubtitleBindings);
        }
    }
}
