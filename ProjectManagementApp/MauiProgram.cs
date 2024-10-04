using CommunityToolkit.Maui;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectManagementApp.Data;
using ProjectManagementApp.Services.Dialog;
using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels;
using ProjectManagementApp.ViewModels.Base;
using ProjectManagementApp.Views;
using System;

namespace ProjectManagementApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Mulish-Regular.ttf", "MulishRegular");
                    fonts.AddFont("Mulish-Medium.ttf", "MulishMedium");
                    fonts.AddFont("Mulish-Light.ttf", "MulishLight");
                    fonts.AddFont("Mulish-ExtraLight.ttf", "MulishEtraLight");
                    fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                    fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
                    fonts.AddFont("Montserrat-Light.ttf", "MontserratLight");
                    fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "faw");
                    fonts.AddFont("Quicksand-Regular.ttf", "QuicksandRegular");
                    fonts.AddFont("Quicksand-Bold.ttf", "QuicksandBold");
                    fonts.AddFont("Quicksand-Medium.ttf", "QuicksandMedium");
                    fonts.AddFont("Quicksand-Light.ttf", "QuicksandLight");
                    fonts.AddFont("Quicksand-SemiBold.ttf", "QuicksandExtraLight");

                });
            builder.Services.AddDbContext<AppDbContext>();



#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.RegisterAppServices();
            builder.RegisterViewModels();
            builder.RegisterViews();

            return builder.Build();
        }

        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            try
            {
                //mauiAppBuilder.Services.AddSingleton<IViewModelBase>();
                mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();
                mauiAppBuilder.Services.AddSingleton<IDialogService, DialogService>();
                mauiAppBuilder.Services.AddSingleton<IDataService, DataService>();
                //return mauiAppBuilder;
            }
            catch (Exception ex) { 
            }
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<HomeViewModel>();
            mauiAppBuilder.Services.AddSingleton<ProjectViewModel>();
            mauiAppBuilder.Services.AddSingleton<EditProjectViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddProjectViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddResourceViewModel>();
            //mauiAppBuilder.Services.AddSingleton<EditProjectActivityViewModel>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<HomeView>();
            mauiAppBuilder.Services.AddSingleton<EditProjectView>();
            mauiAppBuilder.Services.AddSingleton<AddProjectView>();
            mauiAppBuilder.Services.AddSingleton<AddResourceView>();
            //mauiAppBuilder.Services.AddTransient<EditProjectActivityView>();
            return mauiAppBuilder;
        }


    }
}