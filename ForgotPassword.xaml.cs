namespace Attendify;

public partial class ForgotPassword : ContentPage
{
    public ForgotPassword()
    {
        InitializeComponent();
    }

    private async void Reset_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
            string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
        {
            await DisplayAlert("Validation Error", "Please fill in all fields.", "OK");
            return;
        }

        // Basic email validation
        if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
        {
            await DisplayAlert("Validation Error", "Please enter a valid email address.", "OK");
            return;
        }

        if (txtNewPassword.Text != txtConfirmPassword.Text)
        {
            await DisplayAlert("Validation Error", "Passwords do not match.", "OK");
            return;
        }

        // Password strength check (minimum 6 characters)
        if (txtNewPassword.Text.Length < 6)
        {
            await DisplayAlert("Validation Error", "Password must be at least 6 characters long.", "OK");
            return;
        }

        // TODO: Implement password reset logic here (Email verification, DB update, etc.)
        await DisplayAlert("Success", "Password changed successfully!", "OK");

        // Navigate back to login page
        await Navigation.PopAsync();
    }

    private async void GoToLogin_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}