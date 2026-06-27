using LogicBuilder.App.Maui.Forms.Parameters;
using LogicBuilder.Forms.Parameters.Expansions;
using LogicBuilder.Forms.Parameters.Expressions;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class FormRequestDetailsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string getUrl = "api/Entity/GetEntity";
            string addUrl = "api/Student/Save";
            string updateUrl = "api/Student/Save";
            string deleteUrl = "api/Student/Delete";
            Type modelType = typeof(string);
            Type dataType = typeof(int);
            var filter = new FilterLambdaOperatorParameters(null!, null!, null!);
            var selectExpandDefinition = new SelectExpandDefinitionParameters(null!, null!);

            // Act
            var parameters = new FormRequestDetailsParameters(
                getUrl: getUrl,
                addUrl: addUrl,
                updateUrl: updateUrl,
                deleteUrl: deleteUrl,
                modelType: modelType,
                dataType: dataType,
                filter: filter,
                selectExpandDefinition: selectExpandDefinition
            );

            // Assert
            Assert.Equal(getUrl, parameters.GetUrl);
            Assert.Equal(addUrl, parameters.AddUrl);
            Assert.Equal(updateUrl, parameters.UpdateUrl);
            Assert.Equal(deleteUrl, parameters.DeleteUrl);
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(dataType, parameters.DataType);
            Assert.Equal(filter, parameters.Filter);
            Assert.Equal(selectExpandDefinition, parameters.SelectExpandDefinition);
        }
    }
}
