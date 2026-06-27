using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.DataForm;
using LogicBuilder.App.Maui.Forms.Parameters.Directives;
using LogicBuilder.App.Maui.Forms.Parameters.Validation;
using System;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.DataForm
{
    public class FormGroupSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string field = "StudentAddress";
            string title = "Title";
            string validFormControlText = "(Form)";
            string invalidFormControlText = "(Invalid Form)";
            string placeholder = "(Property name)";
            Type modelType = typeof(string);
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

            // Act
            var parameters = new FormGroupSettingsParameters(
                field: field,
                title: title,
                validFormControlText: validFormControlText,
                invalidFormControlText: invalidFormControlText,
                placeholder: placeholder,
                modelType: modelType,
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                conditionalDirectives: conditionalDirectives,
                headerBindings: headerBindings,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(validFormControlText, parameters.ValidFormControlText);
            Assert.Equal(invalidFormControlText, parameters.InvalidFormControlText);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Single(parameters.ValidationMessages);
            Assert.Single(parameters.ConditionalDirectives!);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenFieldshaveRulesOrConditionalDirectivesWithNullValues()
        {
            // Arrange
            string field = "StudentAddress";
            string title = "Title";
            string validFormControlText = "(Form)";
            string invalidFormControlText = "(Invalid Form)";
            string placeholder = "(Property name)";
            Type modelType = typeof(string);
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

            // Act
            var parameters = new FormGroupSettingsParameters(
                field: field,
                title: title,
                validFormControlText: validFormControlText,
                invalidFormControlText: invalidFormControlText,
                placeholder: placeholder,
                modelType: modelType,
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                conditionalDirectives: conditionalDirectives,
                headerBindings: headerBindings,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(validFormControlText, parameters.ValidFormControlText);
            Assert.Equal(invalidFormControlText, parameters.InvalidFormControlText);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Single(parameters.ValidationMessages);
            Assert.Single(parameters.ConditionalDirectives!);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenConditionalDirectivesIsNull()
        {
            // Arrange
            string field = "StudentAddress";
            string title = "Title";
            string validFormControlText = "(Form)";
            string invalidFormControlText = "(Invalid Form)";
            string placeholder = "(Property name)";
            Type modelType = typeof(string);
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

            // Act
            var parameters = new FormGroupSettingsParameters(
                field: field,
                title: title,
                validFormControlText: validFormControlText,
                invalidFormControlText: invalidFormControlText,
                placeholder: placeholder,
                modelType: modelType,
                formGroupTemplate: formGroupTemplate,
                fieldSettings: fieldSettings,
                validationMessages: validationMessages,
                conditionalDirectives: null,
                headerBindings: headerBindings,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(field, parameters.Field);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(validFormControlText, parameters.ValidFormControlText);
            Assert.Equal(invalidFormControlText, parameters.InvalidFormControlText);
            Assert.Equal(placeholder, parameters.Placeholder);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(formGroupTemplate, parameters.FormGroupTemplate);
            Assert.Equal(fieldSettings, parameters.FieldSettings);
            Assert.Single(parameters.ValidationMessages);
            Assert.Null(parameters.ConditionalDirectives);
            Assert.Equal(headerBindings, parameters.HeaderBindings);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
