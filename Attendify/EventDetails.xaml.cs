using Microsoft.Maui.Controls;

namespace Attendify
{
    public partial class EventDetails : ContentPage
    {
        public EventDetails()
        {
            //InitializeComponent();
        }

        private async void OnBackTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            // Navigate to registration page or show a confirmation
            // await Navigation.PushAsync(new RegisterPage());
            await DisplayAlert("Register", "You are about to register for Tech Innovation Summit 2026.", "OK");
        }
    }
}