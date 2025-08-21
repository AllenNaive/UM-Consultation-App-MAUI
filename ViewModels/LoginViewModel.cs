using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using UM_Consultation_App_MAUI.Views;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace UM_Consultation_App_MAUI.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        
        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;

        public ICommand CreateAccountCommand { get; }
        public ICommand LoginCommand { get; }

        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
            CreateAccountCommand = new Command(OnCreateAccount);
            LoginCommand = new RelayCommand(OnLogin);
        }

        private async void OnCreateAccount()
        {
            await _navigation.PushAsync(new CreateAccountPage());
        }

        private async void OnLogin()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Missing Info", "Please enter both email and password.", "OK");
                return;
            }

            // Proceed with login logic
            await Application.Current.MainPage.DisplayAlert("Success", "Logging in...", "OK");
        }


    }
}
