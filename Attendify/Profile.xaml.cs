using System;
using Microsoft.Maui.Controls;

namespace Attendify
{
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }

        // Tap gesture handlers (matching TapGestureRecognizer.Tapped -> TappedEventArgs)
        private void OnHomeTapped(object sender, TappedEventArgs e)
        {
            // Navigation or action for Home tap can be added here.
        }

        private void OnBackTapped(object sender, TappedEventArgs e)
        {
            // Navigation or action for Back tap can be added here.
        }

        private void OnSettingsTapped(object sender, TappedEventArgs e)
        {
            // Navigation or action for Settings tap can be added here.
        }

        private void OnScanTapped(object sender, TappedEventArgs e)
        {
            // Navigation or action for Scan tap can be added here.
        }

        private void OnMyEventsTapped(object sender, TappedEventArgs e)
        {
            // Navigation or action for My Events tap can be added here.
        }

        private void OnProfileTapped(object sender, TappedEventArgs e)
        {
            // Navigation or action for Profile tap can be added here.
        }

        // Button clicked handlers (matching Button.Clicked -> EventArgs)
        private void OnEditProfileTapped(object sender, EventArgs e)
        {
            // Action for Edit Profile button can be added here.
        }

        private void OnLogoutTapped(object sender, EventArgs e)
        {
            // Action for Logout button can be added here.
        }
    }
}