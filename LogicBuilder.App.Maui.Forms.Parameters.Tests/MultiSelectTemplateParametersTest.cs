using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.Forms.Parameters.Expressions;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class MultiSelectTemplateParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string templateName = "MultiSelectTemplate";
            string placeholderText = "(Courses)";
            string textField = "Text";
            string valueField = "Value";
            Type modelType = typeof(string);
            string loadingIndicatorText = "Loading ...";
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(null!, null!, null!, null!, null!);
            string? fieldTypeSource = "Contoso.Domain.Entities.Course";

            // Act
            var parameters = new MultiSelectTemplateParameters(
                templateName: templateName,
                placeholderText: placeholderText,
                textField: textField,
                valueField: valueField,
                modelType: modelType,
                loadingIndicatorText: loadingIndicatorText,
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(templateName, parameters.TemplateName);
            Assert.Equal(placeholderText, parameters.PlaceholderText);
            Assert.Equal(textField, parameters.TextField);
            Assert.Equal(valueField, parameters.ValueField);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(loadingIndicatorText, parameters.LoadingIndicatorText);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
