using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using LogicBuilder.Forms.Parameters.Expressions;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Bindings
{
    public class MultiSelectItemBindingParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string name = "Header";
            string property = "SelectedItems";
            string title = "Select Items";
            string stringFormat = "{0}";
            var keyFields = new List<string> { "Id" };
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                templateName: "MultiSelectTemplate",
                placeholderText: "Title",
                textField: "Text",
                valueField: "Value",
                modelType: typeof(string),
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                fieldTypeSource: null
            );
            string fieldTypeSource = "Contoso.Domain.Entities.Order";
            string listElementTypeSource = "Contoso.Domain.Entities.Item";

            // Act
            var parameters = new MultiSelectItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                keyFields: keyFields,
                multiSelectTemplate: multiSelectTemplate,
                fieldTypeSource: fieldTypeSource,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(property, parameters.Property);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal(multiSelectTemplate, parameters.MultiSelectTemplate);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
            Assert.Equal(listElementTypeSource, parameters.ListElementTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeWithNullFieldTypeSource()
        {
            // Arrange
            string name = "Text";
            string property = "Categories";
            string title = "Categories";
            string stringFormat = "Selected: {0}";
            var keyFields = new List<string> { "CategoryId" };
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                templateName: "MultiSelectTemplate",
                placeholderText: "Title",
                textField: "Text",
                valueField: "Value",
                modelType: typeof(string),
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                fieldTypeSource: null
            );
            string listElementTypeSource = "Contoso.Domain.Entities.Category";

            // Act
            var parameters = new MultiSelectItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                keyFields: keyFields,
                multiSelectTemplate: multiSelectTemplate,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(property, parameters.Property);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal(multiSelectTemplate, parameters.MultiSelectTemplate);
            Assert.Null(parameters.FieldTypeSource);
            Assert.Equal(listElementTypeSource, parameters.ListElementTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeWithCompositeKey()
        {
            // Arrange
            string name = "Detail";
            string property = "AssignedRoles";
            string title = "Roles";
            string stringFormat = "{0}";
            var keyFields = new List<string> { "UserId", "RoleId" };
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                templateName: "MultiSelectTemplate",
                placeholderText: "Title",
                textField: "Text",
                valueField: "Value",
                modelType: typeof(string),
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                fieldTypeSource: null
            );
            string fieldTypeSource = "Contoso.Domain.Entities.User";
            string listElementTypeSource = "Contoso.Domain.Entities.Role";

            // Act
            var parameters = new MultiSelectItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                keyFields: keyFields,
                multiSelectTemplate: multiSelectTemplate,
                fieldTypeSource: fieldTypeSource,
                listElementTypeSource: listElementTypeSource
            );

            // Assert
            Assert.Equal(2, parameters.KeyFields.Count);
            Assert.Contains("UserId", parameters.KeyFields);
            Assert.Contains("RoleId", parameters.KeyFields);
        }

        [Fact]
        public void ConstructorShouldInitializeWithDefaultListElementTypeSource()
        {
            // Arrange
            string name = "Header";
            string property = "Tags";
            string title = "Tags";
            string stringFormat = "{0}";
            var keyFields = new List<string> { "Id" };
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                templateName: "MultiSelectTemplate",
                placeholderText: "Title",
                textField: "Text",
                valueField: "Value",
                modelType: typeof(string),
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                fieldTypeSource: null
            );

            // Act
            var parameters = new MultiSelectItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                keyFields: keyFields,
                multiSelectTemplate: multiSelectTemplate
            );

            // Assert
            Assert.Equal("Enrollment.Domain.Entities", parameters.ListElementTypeSource);
        }
    }
}