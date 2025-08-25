using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using UM_Consultation_App_MAUI.ViewModels;
using UM_Consultation_App_MAUI.Views.FacultyView;

namespace UM_Consultation_App_MAUI
{

    public static class MauiProgram
    {

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();

            // in order for both pages in faculty to be binded by one viewmodel (RequestListViewModel)
            builder.Services.AddSingleton<FacultyRequestViewModel>();
            builder.Services.AddSingleton<RequestListPage>();
            builder.Services.AddSingleton<ConsultationListPage>();
            // end

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}