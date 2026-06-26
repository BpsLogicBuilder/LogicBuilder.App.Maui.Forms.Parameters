using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.Navigation
{
    public class NavigationBarParameters(
        [Comments("Brand text for the navigation bar.")]
        string brandText = "Contoso",

        [Comments("Current module indicator used to determine which menu item gets set to active.")]
        string currentModule = "initial",

        [Comments("List of menu items")]
        List<NavigationMenuItemParameters>? MenuItems = null
    )
    {
        public string BrandText { get; } = brandText;
        public string CurrentModule { get; } = currentModule;
        public List<NavigationMenuItemParameters> MenuItems { get; } = MenuItems ?? [];
    }
}
