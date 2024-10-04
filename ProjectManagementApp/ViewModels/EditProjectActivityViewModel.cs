using ProjectManagementApp.Services.Dialog;
using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectManagementApp.ViewModels
{
    public class EditProjectActivityViewModel : ViewModelBase
    {

        public EditProjectActivityViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService, dataService)
        {
           // AddResourceCommand = new Command(async () => await NavigationService.NavigateToAsync("AddResourceView"));
        }

        
    }
}
