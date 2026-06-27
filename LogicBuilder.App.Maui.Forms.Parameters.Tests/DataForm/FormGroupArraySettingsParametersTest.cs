using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class FormGroupArraySettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "Addresses";
            var keyFields = new List<string> { "ID" };
            string title = "Title";
            string placeholder = "(Form Collection)";
            Type modelType = typeof(string);
            Type type = typeof(List<string>);
            string validFormControlText = "(Form)";
            string invalidFormControlText = "(Invalid Form)";
            var formsCollectionDisplayTemplate = new FormsCollectionDisplayTemplateParameters("HeaderTextDetailTemplate", []);
            var formGroupTemplate = new FormGroupTemplateParameters("PopupFormGroupTemplate");
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Field1", [])
            };
            var conditionalDirectives = new List<VariableDirectivesParameters>
            {
                new("Field1", [])
            };
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";
            string? listElementTypeSource = "Contoso.Domain.Entities.Address";

            // Act
            var parameters = new FormGroupArraySettingsParameters(
                field: field,
                keyFields: keyFields,
                title: title,
                placeholder: placeholder,
                modelType: modelType,
                type: type,
                validFormControlText: validFormControlText,
                invalidFormControlText: invalidFormControlText,
                formsCollectionDisplayTemplate: formsCollectionDisplayTemplate,
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                conditionalDirectives: conditionalDirectives,
                headerBindings: headerBindings,
                fieldTypeSource: fieldTypeSource,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(type, parameters.Type);
            Assert.Equal(validFormControlText, parameters.ValidFormControlText);
            Assert.Equal(invalidFormControlText, parameters.InvalidFormControlText);
            Assert.Equal(formsCollectionDisplayTemplate, parameters.FormsCollectionDisplayTemplate);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Single(parameters.ValidationMessages);
            Assert.Single(parameters.ConditionalDirectives!);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
            Assert.Equal(listElementTypeSource, parameters.ListElementTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenValidationMessagesOrDirectivesHaveFieldsWithNullCollections()
        {
            // Arrange
            string field = "Addresses";
            var keyFields = new List<string> { "ID" };
            string title = "Title";
            string placeholder = "(Form Collection)";
            Type modelType = typeof(string);
            Type type = typeof(List<string>);
            string validFormControlText = "(Form)";
            string invalidFormControlText = "(Invalid Form)";
            var formsCollectionDisplayTemplate = new FormsCollectionDisplayTemplateParameters("HeaderTextDetailTemplate", []);
            var formGroupTemplate = new FormGroupTemplateParameters("PopupFormGroupTemplate");
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Field1", null!)
            };
            var conditionalDirectives = new List<VariableDirectivesParameters>
            {
                new("Field1", null!)
            };
            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";
            string? listElementTypeSource = "Contoso.Domain.Entities.Address";

            // Act
            var parameters = new FormGroupArraySettingsParameters(
                field: field,
                keyFields: keyFields,
                title: title,
                placeholder: placeholder,
                modelType: modelType,
                type: type,
                validFormControlText: validFormControlText,
                invalidFormControlText: invalidFormControlText,
                formsCollectionDisplayTemplate: formsCollectionDisplayTemplate,
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                conditionalDirectives: conditionalDirectives,
                headerBindings: headerBindings,
                fieldTypeSource: fieldTypeSource,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(type, parameters.Type);
            Assert.Equal(validFormControlText, parameters.ValidFormControlText);
            Assert.Equal(invalidFormControlText, parameters.InvalidFormControlText);
            Assert.Equal(formsCollectionDisplayTemplate, parameters.FormsCollectionDisplayTemplate);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Single(parameters.ValidationMessages);
            Assert.Single(parameters.ConditionalDirectives!);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
            Assert.Equal(listElementTypeSource, parameters.ListElementTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenConditionalDirectivesIsNull()
        {
            // Arrange
            string field = "Addresses";
            var keyFields = new List<string> { "ID" };
            string title = "Title";
            string placeholder = "(Form Collection)";
            Type modelType = typeof(string);
            Type type = typeof(List<string>);
            string validFormControlText = "(Form)";
            string invalidFormControlText = "(Invalid Form)";
            var formsCollectionDisplayTemplate = new FormsCollectionDisplayTemplateParameters("HeaderTextDetailTemplate", []);
            var formGroupTemplate = new FormGroupTemplateParameters("PopupFormGroupTemplate");
            var fieldSettings = new List<IFormItemSettingsParameters>
            {
                new InputFieldControlSettingsParameters("Field1", "Title", "Placeholder", "{0}", typeof(string), new TextFieldTemplateParameters("TextTemplate"))
            };
            var validationMessages = new List<ValidationMessageParameters>
            {
                new("Field1", [])
            };

            var headerBindings = new MultiBindingParameters("{0}", ["Field1"]);
            string? fieldTypeSource = "Contoso.Domain.Entities.Student";
            string? listElementTypeSource = "Contoso.Domain.Entities.Address";

            // Act
            var parameters = new FormGroupArraySettingsParameters(
                field: field,
                keyFields: keyFields,
                title: title,
                placeholder: placeholder,
                modelType: modelType,
                type: type,
                validFormControlText: validFormControlText,
                invalidFormControlText: invalidFormControlText,
                formsCollectionDisplayTemplate: formsCollectionDisplayTemplate,
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                conditionalDirectives: null,
                headerBindings: headerBindings,
                fieldTypeSource: fieldTypeSource,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(type, parameters.Type);
            Assert.Equal(validFormControlText, parameters.ValidFormControlText);
            Assert.Equal(invalidFormControlText, parameters.InvalidFormControlText);
            Assert.Equal(formsCollectionDisplayTemplate, parameters.FormsCollectionDisplayTemplate);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Single(parameters.ValidationMessages);
            Assert.Null(parameters.ConditionalDirectives);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
            Assert.Equal(listElementTypeSource, parameters.ListElementTypeSource);
        }
    }
}
