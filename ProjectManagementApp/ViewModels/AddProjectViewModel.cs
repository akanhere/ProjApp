using ProjectManagementApp.Models;
using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace ProjectManagementApp.ViewModels
{
    public class AddProjectViewModel : ViewModelBase
    {
        private Project _project;
        public Project Project
        {
            get => _project;
            set
            {
                _project = value;
                OnPropertyChanged(nameof(Project));
            }
        }

        public ObservableCollection<ProjectActivity> ProjectActivities { get; set; }
        public ICommand AddActivityCommand { get; }
        public ICommand SaveCommand { get; }

        public AddProjectViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService, dataService)
        {
            Project = new Project();
            ProjectActivities = new ObservableCollection<ProjectActivity>();
            AddActivityCommand = new Command(AddActivity);
            SaveCommand = new Command(async () => await SaveProject());
        }

        private void AddActivity()
        {
            ProjectActivities.Add(new ProjectActivity());
        }

        private async Task SaveProject()
        {
            Project.ProjectActivities = ProjectActivities.Where(a=>a.Title != null).ToList();
            await DataService.AddProjectAsync(Project);
            await NavigationService.PopAsync();
        }
    }
}
