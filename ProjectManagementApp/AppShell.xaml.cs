using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.Views;

namespace ProjectManagementApp
{
    public partial class AppShell : Shell
    {
        private readonly INavigationService _navigationService;
        public AppShell(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeRouting();
            InitializeComponent();
            
        }

        private static void InitializeRouting()
        {
            Routing.RegisterRoute("Home", typeof(HomeView));
            Routing.RegisterRoute("EditProjectView", typeof(EditProjectView));
            Routing.RegisterRoute("AddProjectView", typeof(AddProjectView));
            Routing.RegisterRoute("AddResourceView", typeof(AddResourceView));
        }
    }
}
