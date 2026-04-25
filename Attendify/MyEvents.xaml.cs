using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace Attendify
{
    public partial class MyEvents : ContentPage
    {
        public MyEvents()
        {
            InitializeComponent();
            ShowUpcoming(); // Show upcoming events by default
        }

        private async void OnNotificationTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Notifications", "You have no new notifications.", "OK");
        }

        private void OnUpcomingTabTapped(object sender, EventArgs e)
        {
            ShowUpcoming();
        }

        private void OnAttendedTabTapped(object sender, EventArgs e)
        {
            ShowAttended();
        }

        private void OnMissedTabTapped(object sender, EventArgs e)
        {
            ShowMissed();
        }

        private void ShowUpcoming()
        {
            UpcomingContent.IsVisible = true;
            AttendedContent.IsVisible = false;
            MissedContent.IsVisible = false;

            UpcomingTab.BackgroundColor = Color.FromArgb("#FFFFFF");
            AttendedTab.BackgroundColor = Colors.Transparent;
            MissedTab.BackgroundColor = Colors.Transparent;

            var upcomingLabel = (Label)UpcomingTab.Content;
            var attendedLabel = (Label)AttendedTab.Content;
            var missedLabel = (Label)MissedTab.Content;

            upcomingLabel.TextColor = Color.FromArgb("#1E40AF");
            upcomingLabel.FontAttributes = FontAttributes.Bold;
            attendedLabel.TextColor = Color.FromArgb("#CBD5E1");
            attendedLabel.FontAttributes = FontAttributes.None;
            missedLabel.TextColor = Color.FromArgb("#CBD5E1");
            missedLabel.FontAttributes = FontAttributes.None;
        }

        private void ShowAttended()
        {
            UpcomingContent.IsVisible = false;
            AttendedContent.IsVisible = true;
            MissedContent.IsVisible = false;

            UpcomingTab.BackgroundColor = Colors.Transparent;
            AttendedTab.BackgroundColor = Color.FromArgb("#FFFFFF");
            MissedTab.BackgroundColor = Colors.Transparent;

            var upcomingLabel = (Label)UpcomingTab.Content;
            var attendedLabel = (Label)AttendedTab.Content;
            var missedLabel = (Label)MissedTab.Content;

            upcomingLabel.TextColor = Color.FromArgb("#CBD5E1");
            upcomingLabel.FontAttributes = FontAttributes.None;
            attendedLabel.TextColor = Color.FromArgb("#1E40AF");
            attendedLabel.FontAttributes = FontAttributes.Bold;
            missedLabel.TextColor = Color.FromArgb("#CBD5E1");
            missedLabel.FontAttributes = FontAttributes.None;
        }

        private void ShowMissed()
        {
            UpcomingContent.IsVisible = false;
            AttendedContent.IsVisible = false;
            MissedContent.IsVisible = true;

            UpcomingTab.BackgroundColor = Colors.Transparent;
            AttendedTab.BackgroundColor = Colors.Transparent;
            MissedTab.BackgroundColor = Color.FromArgb("#FFFFFF");

            var upcomingLabel = (Label)UpcomingTab.Content;
            var attendedLabel = (Label)AttendedTab.Content;
            var missedLabel = (Label)MissedTab.Content;

            upcomingLabel.TextColor = Color.FromArgb("#CBD5E1");
            upcomingLabel.FontAttributes = FontAttributes.None;
            attendedLabel.TextColor = Color.FromArgb("#CBD5E1");
            attendedLabel.FontAttributes = FontAttributes.None;
            missedLabel.TextColor = Color.FromArgb("#1E40AF");
            missedLabel.FontAttributes = FontAttributes.Bold;
        }

        private async void OnViewQRTapped(object sender, EventArgs e)
        {
            await DisplayAlert("QR Ticket", "Displaying QR code ticket...", "OK");
        }

        private async void OnViewCertificateTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Certificate", "Viewing certificate...", "OK");
        }

        private async void OnDownloadReceiptTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Receipt", "Downloading receipt...", "OK");
        }

        private async void OnViewEventInfoTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Event Info", "Viewing event information...", "OK");
        }

        private async void OnHomeTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }

        private async void OnEventsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Events());
        }

        private async void OnScanTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Scan", "Open QR/Barcode scanner.", "OK");
        }

        private async void OnProfileTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());
        }

        private void OnMyEventsTapped(object sender, EventArgs e)
        {
            // Handle the My Events tab tap here
            // For example, you might want to navigate or update UI
        }
    }
}