namespace ProjectCoffeeV3.Controls;

public partial class FoodCardUI : ContentView
{
    public static readonly BindableProperty FoodImageSourceProperty = BindableProperty.Create(nameof(FoodImageSource), typeof(string), typeof(FoodCardUI), string.Empty);
    public static readonly BindableProperty FoodNameProperty = BindableProperty.Create(nameof(FoodName), typeof(string), typeof(FoodCardUI), string.Empty);
    public static readonly BindableProperty FoodPriceProperty = BindableProperty.Create(nameof(FoodPrice), typeof(string), typeof(FoodCardUI), string.Empty);
    public static readonly BindableProperty FoodDescProperty = BindableProperty.Create(nameof(FoodDesc), typeof(string), typeof(FoodCardUI), string.Empty);

    public string FoodImageSource
    {
        get => (string)GetValue(FoodImageSourceProperty);
        set => SetValue(FoodImageSourceProperty, value);
    }

    public string FoodName
    {
        get => (string)GetValue(FoodNameProperty);
        set => SetValue(FoodNameProperty, value);
    }

    public string FoodPrice
    {
        get => (string)GetValue(FoodPriceProperty);
        set => SetValue(FoodPriceProperty, value);
    }

    public string FoodDesc
    {
        get => (string)GetValue(FoodDescProperty);
        set => SetValue(FoodDescProperty, value);
    }

    public FoodCardUI()
    {
        InitializeComponent();
    }
}