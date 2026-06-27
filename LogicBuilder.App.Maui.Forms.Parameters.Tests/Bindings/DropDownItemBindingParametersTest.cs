using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Bindings
{
    public class DropDownItemBindingParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string name = "Header";
            string property = "Name";
            string title = "Select Item";
            string stringFormat = "{0}";
            var dropDownTemplate = new DropDownTemplateParameters(
                templateName: "PickerTemplate",
                titleText: "Title",
                textField: "Text",
                valueField: "Value",
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                reloadItemsFlowName: null
            );
            bool requiresReload = false;
            string fieldTypeSource = "Contoso.Domain.Entities.Customer";

            // Act
            var parameters = new DropDownItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                dropDownTemplate: dropDownTemplate,
                requiresReload: requiresReload,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(property, parameters.Property);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(dropDownTemplate, parameters.DropDownTemplate);
            Assert.Equal(requiresReload, parameters.RequiresReload);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeWithNullFieldTypeSource()
        {
            // Arrange
            string name = "Text";
            string property = "Description";
            string title = "Item Description";
            string stringFormat = "Value: {0}";
            var dropDownTemplate = new DropDownTemplateParameters(
                templateName: "PickerTemplate",
                titleText: "Title",
                textField: "Text",
                valueField: "Value",
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                reloadItemsFlowName: null
            );
            bool requiresReload = true;

            // Act
            var parameters = new DropDownItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                dropDownTemplate: dropDownTemplate,
                requiresReload: requiresReload
            );

            // Assert
            Assert.Equal(name, parameters.Name);
            Assert.Equal(property, parameters.Property);
            Assert.Equal(title, parameters.Title);
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(dropDownTemplate, parameters.DropDownTemplate);
            Assert.Equal(requiresReload, parameters.RequiresReload);
            Assert.Null(parameters.FieldTypeSource);
        }

        [Fact]
        public void ConstructorShouldInitializeWithRequiresReloadTrue()
        {
            // Arrange
            string name = "Detail";
            string property = "Category";
            string title = "Category";
            string stringFormat = "{0}";
            var dropDownTemplate = new DropDownTemplateParameters(
                templateName: "PickerTemplate",
                titleText: "Title",
                textField: "Text",
                valueField: "Value",
                loadingIndicatorText: "loading",
                textAndValueSelector: new SelectorLambdaOperatorParameters(null!, null!, null!),
                requestDetails: new RequestDetailsParameters(null!, null!, null!, null!, null!),
                reloadItemsFlowName: "ReloadCategories"
            );
            bool requiresReload = true;
            string fieldTypeSource = "Contoso.Domain.Entities.Product";

            // Act
            var parameters = new DropDownItemBindingParameters(
                name: name,
                property: property,
                title: title,
                stringFormat: stringFormat,
                dropDownTemplate: dropDownTemplate,
                requiresReload: requiresReload,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.True(parameters.RequiresReload);
            Assert.Equal("ReloadCategories", parameters.DropDownTemplate.ReloadItemsFlowName);
        }
    }
}