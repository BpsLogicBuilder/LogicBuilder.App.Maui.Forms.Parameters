using LogicBuilder.App.Maui.Forms.Parameters.Navigation;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Navigation
{
    public class NavigationMenuItemParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string initialModule = "initial";
            string text = "menuText";
            string icon = "Home";
            var subItems = new List<NavigationMenuItemParameters>
            {
                new("submenu", "SubMenu", "List")
            };

            // Act
            var parameters = new NavigationMenuItemParameters(
                initialModule: initialModule,
                text: text,
                icon: icon,
                active: true,
                SubItems: subItems
            );

            // Assert
            Assert.Equal(initialModule, parameters.InitialModule);
            Assert.Equal(text, parameters.Text);
            Assert.Equal(icon, parameters.Icon);
            Assert.Equal(subItems, parameters.SubItems);
        }
    }
}
