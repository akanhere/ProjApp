using CommunityToolkit.Mvvm.Input;
using ProjectManagementApp.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.ViewModels.Base
{
    public interface IViewModelBase : IQueryAttributable
    {
        public INavigationService NavigationService { get; }

        public IDataService DataService { get; }

        public IAsyncRelayCommand InitializeAsyncCommand { get; }

        public bool IsBusy { get; }

        public bool IsInitialized { get; }

        public Task InitializeAsync();
    }
}
