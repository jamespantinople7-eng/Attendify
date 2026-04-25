using Microsoft.Maui.Controls;

namespace Attendify
{
    public partial class Login : ContentPage
    {
        private bool _isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
        }

        private void TogglePassword_Tapped(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            txtPassword.IsPassword = !_isPasswordVisible;

            // Swap the eye icon based on visibility state
            if (sender is Image eyeIcon)
            {
                eyeIcon.Source = _isPasswordVisible ? "ic_eye_on.png" : "ic_eye_off.png";
            }
        }

        private async void Login_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }


        private async void ForgotPassword_Tapped(object sender, EventArgs e)
        {
            // TODO: Navigate to forgot password page
            await DisplayAlert("Forgot Password", "Password reset instructions will be sent to your email.", "OK");
        }

        private async void SignUp_Tapped(object sender, EventArgs e)
        {
            // TODO: Navigate to sign up page
            // await Navigation.PushAsync(new SignUp());
            await DisplayAlert("Sign Up", "Redirecting to Sign Up page.", "OK");
     

            // After
            await Navigation.PushAsync(new Signup());
        }
    }


}
