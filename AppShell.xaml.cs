namespace Attendify
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Homepage", typeof(Homepage));
        }
    }
}