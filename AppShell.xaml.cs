using UM_Consultation_App_MAUI.Views;

namespace UM_Consultation_App_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("CreateAccountPage", typeof(CreateAccountPage));

        }
    }
}
