using LogicBuilder.App.Maui.Forms.Parameters;
using System;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class RequestDetailsParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            Type modelType = typeof(string);
            Type dataType = typeof(int);
            Type modelReturnType = typeof(decimal);
            Type dataReturnType = typeof(bool);
            string dataSourceUrl = "api/List/GetList";

            // Act
            var parameters = new RequestDetailsParameters(
                modelType: modelType,
                dataType: dataType,
                modelReturnType: modelReturnType,
                dataReturnType: dataReturnType,
                dataSourceUrl: dataSourceUrl
            );

            // Assert
            Assert.Equal(modelType, parameters.ModelType);
            Assert.Equal(dataType, parameters.DataType);
            Assert.Equal(modelReturnType, parameters.ModelReturnType);
            Assert.Equal(dataReturnType, parameters.DataReturnType);
            Assert.Equal(dataSourceUrl, parameters.DataSourceUrl);
        }
    }
}
