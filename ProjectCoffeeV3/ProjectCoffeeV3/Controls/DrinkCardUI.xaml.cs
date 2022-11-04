namespace ProjectCoffeeV3.Controls;

public partial class DrinkCardUI : ContentView
{
    public static readonly BindableProperty DrinkImageSourceProperty = BindableProperty.Create(nameof(DrinkImageSource), typeof(string), typeof(DrinkCardUI), string.Empty);
    public static readonly BindableProperty DrinkNameProperty = BindableProperty.Create(nameof(DrinkName), typeof(string), typeof(DrinkCardUI), string.Empty);
    public static readonly BindableProperty DrinkPriceProperty = BindableProperty.Create(nameof(DrinkPrice), typeof(string), typeof(DrinkCardUI), string.Empty);

    public string DrinkImageSource
    {
        get => (string)GetValue(DrinkImageSourceProperty);
        set => SetValue(DrinkImageSourceProperty, value);
    }

    public string DrinkName
    {
        get => (string)GetValue(DrinkNameProperty);
        set => SetValue(DrinkNameProperty, value);
    }

    public string DrinkPrice
    {
        get => (string)GetValue(DrinkPriceProperty);
        set => SetValue(DrinkPriceProperty, value);
    }

    public DrinkCardUI()
    {
        InitializeComponent();
    }
}