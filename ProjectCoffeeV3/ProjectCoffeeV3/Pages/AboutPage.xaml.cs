using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui;

namespace ProjectCoffeeV3.Pages;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void Facebook(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://www.facebook.com");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }

    private async void Instagram(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://www.instagram.com");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }
}