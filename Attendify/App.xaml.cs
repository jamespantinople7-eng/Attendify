namespace Attendify;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new SplashScreen();
    }
}