using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace Attendify
{
    public partial class Events : ContentPage
    {
        public Events()
        {
            InitializeComponent();
        }

        // Notification Icon
        private async void OnNotificationTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Notifications", "You have no new notifications.", "OK");
        }

        // Filter Buttons       
        private async void OnDateFilterTapped(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Sort by Date", "Cancel", null, "Today", "Tomorrow", "This Week", "This Month");
        }

        private async void OnCategoryFilterTapped(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Select Category", "Cancel", null, "All", "Academic", "Innovation", "Cultural", "Workshop", "Sports");
        }

        private async void OnLocationFilterTapped(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Select Location", "Cancel", null, "All", "Main Hall", "Audio Visual Center", "Campus Arena", "Design Lab");
        }

        // Register Button
        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Register Event", "Would you like to register for this event?", "Yes", "No");

            if (result)
            {
                await DisplayAlert("Success", "You have successfully registered for this event!", "OK");
            }
        }

        // Bottom Navigation Handlers
        private async void OnScanTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Scan", "Open QR/Barcode scanner.", "OK");
        }

        private async void OnProfileTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }

        private void OnHomeTapped(object sender, EventArgs e)
        {
            // Navigate to the Home page or implement your logic here.
        }

        private void OnMyEventsTapped(object sender, EventArgs e)
        {
            // TODO: Add navigation or logic for "My Events" tap
        }
    }
}