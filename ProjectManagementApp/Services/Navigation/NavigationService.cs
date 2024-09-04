
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.Services.Navigation
{
    public class MauiNavigationService : INavigationService
    {

        public MauiNavigationService()
        {

        }

        public async Task InitializeAsync()
        {
            //var user = await _appEnvironmentService.IdentityService.GetUserInfoAsync();

            await NavigateToAsync("//Home");
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters != null
                ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
                : Shell.Current.GoToAsync(shellNavigation);
        }

        public Task PopAsync()
        {
            return Shell.Current.GoToAsync("..");
        }
    }
}
