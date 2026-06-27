using LogicBuilder.App.Maui.Forms.Parameters;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class MultiBindingParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string stringFormat = "Value: {0:F2} {1}";
            var fields = new List<string> { "Field1", "Field2" };
            string? fieldTypeSource = "Contoso.Domain.Entities.Customer";

            // Act
            var parameters = new MultiBindingParameters(
                stringFormat: stringFormat,
                fields: fields,
                fieldTypeSource: fieldTypeSource
            );

            // Assert
            Assert.Equal(stringFormat, parameters.StringFormat);
            Assert.Equal(fields, parameters.Fields);
            Assert.Equal(fieldTypeSource, parameters.FieldTypeSource);
        }
    }
}
