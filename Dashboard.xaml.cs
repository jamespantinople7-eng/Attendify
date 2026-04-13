using Microsoft.Maui.Controls;
using System;

namespace Attendify
{
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void OnNotificationTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Notifications", "No new notifications.", "OK");
        }

        private void OnSearchTapped(object sender, EventArgs e)
        {
            // TODO
        }

        private async void OnRegisterEventTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails());
        }

        private async void OnScanQRTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Scan QR", "Opening QR scanner...", "OK");
        }

        private async void OnScanTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Scan", "Opening QR scanner...", "OK");
        }

        private async void OnViewAllTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Events", "Viewing all events...", "OK");
        }

        private async void OnEventTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventDetails());
        }
    }
}