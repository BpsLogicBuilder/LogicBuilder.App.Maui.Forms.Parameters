using LogicBuilder.App.Maui.Forms.Parameters.Navigation;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests.Navigation
{
    public class NavigationBarParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string brandText = "Contoso";
            string currentModule = "initial";
            var menuItems = new List<NavigationMenuItemParameters>
            {
                new("home", "Home", "Home")
            };

            // Act
            var parameters = new NavigationBarParameters(
                brandText: brandText,
                currentModule: currentModule,
                MenuItems: menuItems
            );

            // Assert
            Assert.Equal(brandText, parameters.BrandText);
            Assert.Equal(currentModule, parameters.CurrentModule);
            Assert.Equal(menuItems, parameters.MenuItems);
        }

        [Fact]
        public void ConstructorShouldInitializeAllPropertiesWhenMenuItemsIsNull()
        {
            // Arrange
            string brandText = "Contoso";
            string currentModule = "initial";

            // Act
            var parameters = new NavigationBarParameters(
                brandText: brandText,
                currentModule: currentModule,
                MenuItems: null
            );

            // Assert
            Assert.Equal(brandText, parameters.BrandText);
            Assert.Equal(currentModule, parameters.CurrentModule);
            Assert.Empty(parameters.MenuItems);
        }
    }
}
