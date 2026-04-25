
namespace Attendify;

public partial class SplashScreen : ContentPage
{
    public SplashScreen()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Initialize UI components here
        // Example: this.Title = "Splash Screen";
        // Add any other necessary component initialization code.
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await Task.Delay(3000);

        await Shell.Current.GoToAsync($"//{nameof(Login)}");
    }
}