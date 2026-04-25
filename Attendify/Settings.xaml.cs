using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Attendify
{
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        // 🔙 Back Button
        private async void OnBackTapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // Profile Information
        private async void OnProfileInfoTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProfile());
        }

        // Change Password
        private async void OnChangePasswordTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Change Password", "Navigate to change password screen.", "OK");
        }

        // Linked Accounts
        private async void OnLinkedAccountsTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Linked Accounts", "Manage linked accounts (not implemented).", "OK");
        }

        // Event Reminders
        private async void OnEventRemindersTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Event Reminders", "Configure event reminders (not implemented).", "OK");
        }

        // Language
        private async void OnLanguageTapped(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Select Language", "Cancel", null, "English", "Filipino", "Cebuano");
            // TODO: Handle language change
        }

        // Help Center
        private async void OnHelpCenterTapped(object sender, EventArgs e)
        {
            // TODO: Open help center URL or page
            await DisplayAlert("Help Center", "Opening help center...", "OK");
        }

        // Privacy Policy
        private async void OnPrivacyPolicyTapped(object sender, EventArgs e)
        {
            // TODO: Open privacy policy
            await DisplayAlert("Privacy Policy", "View privacy policy.", "OK");
        }

        // Terms of Service
        private async void OnTermsOfServiceTapped(object sender, EventArgs e)
        {
            // TODO: Open terms of service
            await DisplayAlert("Terms of Service", "View terms of service.", "OK");
        }

        // Delete Account
        private async void OnDeleteAccountTapped(object sender, EventArgs e)
        {
            var confirm = await DisplayAlert(
                "Delete Account",
                "Are you sure you want to delete your account? This action cannot be undone and all your data will be permanently removed.",
                "Delete",
                "Cancel");

            if (confirm)
            {
                // Show final confirmation
                var finalConfirm = await DisplayAlert(
                    "Final Warning",
                    "This will permanently delete your account. Type 'DELETE' to confirm.",
                    "Confirm Delete",
                    "Cancel");

                if (finalConfirm)
                {
                    // TODO: Implement account deletion logic
                    await DisplayAlert("Success", "Your account has been deleted.", "OK");
                    await Navigation.PopToRootAsync();
                }
            }
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

        // FIX: Use the TappedEventArgs signature for TapGestureRecognizer.Tapped
        private async void OnHomeTapped(object sender, TappedEventArgs e)
        {
            // Navigate to root (Home)
            await Navigation.PopToRootAsync();
        }

        private void OnMyEventsTapped(object sender, EventArgs e)
        {
            // Handle tap for "My Events".
            // Example navigation (uncomment and adjust if MyEventsPage exists):
            // await Navigation.PushAsync(new MyEventsPage());

            // If synchronous action is fine, perform it here.
        }
    }
}
