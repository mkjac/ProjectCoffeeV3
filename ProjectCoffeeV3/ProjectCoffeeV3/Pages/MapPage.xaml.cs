using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace ProjectCoffeeV3.Pages;

public partial class MapPage : ContentPage
{
    public MapPage()
    {
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var cafeLoc = new Location(-36.86807933012006, 174.77576536889677);

        MapSpan mapSpan = MapSpan.FromCenterAndRadius(cafeLoc, Distance.FromKilometers(1));
        map.MoveToRegion(mapSpan);
        map.Scale = 1.5f;
        map.IsZoomEnabled = true;
        map.IsScrollEnabled = true;
        map.Pins.Add(new Pin
        {
            Label = "Jules Cafe",
            Location = cafeLoc,
        });
    }
}