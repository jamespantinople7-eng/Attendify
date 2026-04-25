using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace Attendify
{
    public partial class EditProfile : ContentPage
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        // Change Profile Picture
        private async void OnChangePhotoTapped(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Change Profile Picture", "Cancel", null, "Take Photo", "Choose from Gallery");

            if (result == "Take Photo")
            {
                // TODO: Integrate camera functionality
                await DisplayAlert("Camera", "Camera integration coming soon.", "OK");
            }
            else if (result == "Choose from Gallery")
            {
                // TODO: Integrate photo picker
                await DisplayAlert("Gallery", "Photo picker integration coming soon.", "OK");
            }
        }

        // Save Changes
        private async void OnSaveChangesTapped(object sender, EventArgs e)
        {
            // TODO: Validate and save user data to database/local storage

            await DisplayAlert("Success", "Profile updated successfully!", "OK");

            // Navigate back to Profile previousPage
            Page previousPage = await Navigation.PopAsync();
        }

        // Bottom Navigation Handlers
        private async void OnScanTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Scan", "Open QR/Barcode scanner.", "OK");
        }

        private async void OnProfileTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // Home tap from XAML: <TapGestureRecognizer Tapped="OnHomeTapped" />
        private async void OnHomeTapped(object sender, EventArgs e)
        {
            // Try to go back if possible; otherwise do nothing.
            if (Navigation?.NavigationStack?.Count > 1)
            {
                await Navigation.PopAsync();
            }
        }

        // My Events tap: <TapGestureRecognizer Tapped="OnMyEventsTapped" />
        private async void OnMyEventsTapped(object sender, EventArgs e)
        {
            await DisplayAlert("My Events", "My Events tapped.", "OK");
        }
    }
}