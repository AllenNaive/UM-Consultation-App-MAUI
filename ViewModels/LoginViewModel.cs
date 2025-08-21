using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UM_Consultation_App_MAUI.Views;

namespace UM_Consultation_App_MAUI.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        public ICommand CreateAccountCommand { get; }
        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
            CreateAccountCommand = new Command(OnCreateAccount);
        }

        private async void OnCreateAccount()
        {
            await _navigation.PushAsync(new CreateAccountPage());
        }

    }
}
