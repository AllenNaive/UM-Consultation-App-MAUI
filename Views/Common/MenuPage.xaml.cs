using UM_Consultation_App_MAUI.ViewModels;
using UM_Consultation_App_MAUI.Views.FacultyView;
using UM_Consultation_App_MAUI.Views.StudentView;

namespace UM_Consultation_App_MAUI.Views.Common;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
        BindingContext = new MenuViewModel();
        if (UserSession.IsFaculty)
        {
            BottomNavContainer.Content = new FacultyBottomNav();
        }
        else
        {
            BottomNavContainer.Content = new StudentBottomNav();
        }


    }
}