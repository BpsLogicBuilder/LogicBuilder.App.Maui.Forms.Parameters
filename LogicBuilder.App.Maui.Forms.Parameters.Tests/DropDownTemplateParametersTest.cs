using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.Forms.Parameters.Expressions;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class DropDownTemplateParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string templateName = "PickerTemplate";
            string titleText = "Select Item";
            string textField = "Text";
            string valueField = "Value";
            string loadingIndicatorText = "Loading ...";
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(null!, null!, null!, null!, null!);
            string? reloadItemsFlowName = "ReloadFlow";
            string? fieldTypeSource = "Contoso.Domain.Entities.Customer";

            // Act
            var parameters = new DropDownTemplateParameters(
                templateName: templateName,
                titleText: titleText,
                textField: textField,
                valueField: valueField,
                loadingIndicatorText: loadingIndicatorText,
                textAndValueSelector: textAndValueSelector,
                requestDetails: requestDetails,
                reloadItemsFlowName: reloadItemsFlowName,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(templateName, parameters.TemplateName);
            Assert.Equal(titleText, parameters.TitleText);
            Assert.Equal(textField, parameters.TextField);
            Assert.Equal(valueField, parameters.ValueField);
            Assert.Equal(loadingIndicatorText, parameters.LoadingIndicatorText);
            Assert.Equal(textAndValueSelector, parameters.TextAndValueSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
            Assert.Equal(reloadItemsFlowName, parameters.ReloadItemsFlowName);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
