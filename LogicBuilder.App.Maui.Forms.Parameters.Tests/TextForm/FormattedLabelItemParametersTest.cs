using LogicBuilder.App.Maui.Forms.Parameters.TextForm;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.TextForm
{
    public class FormattedLabelItemParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            var items = new List<ISpanItemParameters>
            {
                new SpanItemParameters("Span text"),
                new HyperLinkSpanItemParameters("Link text", "http://example.com")
            };

            // Act
            var parameters = new FormattedLabelItemParameters(
                items: items
            );

            // Assert
            Assert.Equal(items, parameters.Items);
            Assert.Equal(2, parameters.Items.Count);
        }
    }
}
