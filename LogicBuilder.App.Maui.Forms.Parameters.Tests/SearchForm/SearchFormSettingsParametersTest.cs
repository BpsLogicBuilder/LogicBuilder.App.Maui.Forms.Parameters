using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.App.Maui.Forms.Parameters.Bindings;
using LogicBuilder.App.Maui.Forms.Parameters.SearchForm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.SearchForm
{
    public class SearchFormSettingsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string title = "Title";
            Type modelType = typeof(string);
            string loadingIndicatorText = "Loading ...";
            string itemTemplateName = "HeaderTextDetailTemplate";
            string filterPlaceholder = "Filter";
            string createPagingSelectorFlowName = "paging_selector_models";
            var bindings = new List<ItemBindingParameters>
            {
                new TextItemBindingParameters("Header", "Name", "Header Text", "{0}", new TextFieldTemplateParameters("TextTemplate"))
            };
            var requestDetails = new RequestDetailsParameters(null!, null!, null!, null!, null!);

            // Act
            var parameters = new SearchFormSettingsParameters(
                title: title,
                modelType: modelType,
                loadingIndicatorText: loadingIndicatorText,
                itemTemplateName: itemTemplateName,
                filterPlaceholder: filterPlaceholder,
                createPagingSelectorFlowName: createPagingSelectorFlowName,
                bindings: bindings,
                requestDetails: requestDetails
            );

            // Assert
            Assert.Equal(title, parameters.Title);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(loadingIndicatorText, parameters.LoadingIndicatorText);
            Assert.Equal(itemTemplateName, parameters.ItemTemplateName);
            Assert.Equal(filterPlaceholder, parameters.FilterPlaceholder);
            Assert.Equal(createPagingSelectorFlowName, parameters.CreatePagingSelectorFlowName);
            Assert.Single(parameters.Bindings);
            Assert.Equal(requestDetails, parameters.RequestDetails);
        }
    }
}
