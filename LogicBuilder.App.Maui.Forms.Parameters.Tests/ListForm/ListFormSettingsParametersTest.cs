using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using LogicBuilder.App.Maui.Forms.Parameters.ListForm;
using LogicBuilder.Forms.Parameters.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.ListForm
{
    public class ListFormSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string title = "Title";
            Type modelType = typeof(string);
            string loadingIndicatorText = "Loading ...";
            string itemTemplateName = "HeaderTextDetailTemplate";
            var bindings = new List<ItemBindingParameters>
            {
                new TextItemBindingParameters("Header", "Name", "Header Text", "{0}", new TextFieldTemplateParameters("TextTemplate"))
            };
            var fieldsSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(null!, null!, null!, null!, null!);

            // Act
            var parameters = new ListFormSettingsParameters(
                title: title,
                modelType: modelType,
                loadingIndicatorText: loadingIndicatorText,
                itemTemplateName: itemTemplateName,
                bindings: bindings,
                fieldsSelector: fieldsSelector,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(loadingIndicatorText, parameters.LoadingIndicatorText);
            Assert.Equal(itemTemplateName, parameters.ItemTemplateName);
            Assert.Single(parameters.Bindings);
            Assert.Equal(fieldsSelector, parameters.FieldsSelector);
            Assert.Equal(requestDetails, parameters.RequestDetails);
        }
    }
}
