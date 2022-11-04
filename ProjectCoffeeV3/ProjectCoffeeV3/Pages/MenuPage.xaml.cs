using ProjectCoffeeV3.Nav;
using System.Linq.Expressions;

namespace ProjectCoffeeV3.Pages;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private async void OpenNav(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        switch (b.Text)
        {
            case "Espresso":
                ContentPage page = new Nav.EspressoPage();
                await Navigation.PushAsync(page);
                break;
            case "Hot Drinks":
                await Navigation.PushAsync(new Nav.HotDrinksPage());
                break;
            case "Cold Drinks":
                await Navigation.PushAsync(new Nav.ColdDrinksPage());
                break;
            case "Quick Bites":
                await Navigation.PushAsync(new Nav.QuickBitesPage());
                break;
            default:
                // code block
                break;
        }
    }
}