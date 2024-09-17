using ProjectManagementApp.Models;
using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace ProjectManagementApp.ViewModels
{
    public class EditProjectViewModel : ViewModelBase, IQueryAttributable
    {
        private ProjectViewModel _project;

        public ProjectViewModel Project
        {
            get => _project;
            set
            {
                _project = value;
                OnPropertyChanged(nameof(Project));
            }
        }

        public ICommand SaveCommand { get; }

        public EditProjectViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService, dataService)
        {
            SaveCommand = new Command(async () => await SaveProject());
        }

        public override Task InitializeAsync()
        {
            //Project.Name = 
            return base.InitializeAsync();
        }

        private async Task SaveProject()
        {
            var project = new Project
            {
                Name = Project.Name,
                Description = Project.Description
            };

            await DataService.UpdateProjectAsync(project);
            await NavigationService.PopAsync();
        }


        public override void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("project") && query["project"] is ProjectViewModel project)
            {
                Project = project;
            }
        }
    }
}
