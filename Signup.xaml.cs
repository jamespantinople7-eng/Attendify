using Microsoft.Maui.Controls;

namespace Attendify
{
    public partial class Signup : ContentPage
    {
        private bool _isPasswordVisible = false;

        public Signup()
        {
            InitializeComponent();
        }

        private void TogglePassword_Tapped(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            txtPassword.IsPassword = !_isPasswordVisible;
            //imgEyeToggle.Source = _isPasswordVisible ? "ic_eye_on.png" : "ic_eye_off.png";
        }

        private async void SignUp_Tapped(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text?.Trim() ?? string.Empty;
            string studentId = txtStudentId.Text?.Trim() ?? string.Empty;
            string email = txtEmail.Text?.Trim() ?? string.Empty;
            string password = txtPassword.Text?.Trim() ?? string.Empty;
            string course = txtCourse.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(fullname) ||
                string.IsNullOrEmpty(studentId) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(course))
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            // TODO: Add your registration logic here
            // await Navigation.PushAsync(new MainPage());
        }

        private async void Login_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
