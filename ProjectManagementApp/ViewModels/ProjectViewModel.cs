using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels.Base;
using System.Windows.Input;

namespace ProjectManagementApp.ViewModels
{
    public class ProjectViewModel : ViewModelBase
    {
        public ICommand EditCommand { get; set; }
        public ProjectViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService, dataService)
        {
            EditCommand = new Command<ProjectViewModel>(async (project) => await EditProject(project));
        }

        private async Task EditProject(ProjectViewModel project)
        {
            // Navigate to the edit page with the selected project
            var parameters = new Dictionary<string, object>
            {
                { "project", project }
            };
            await NavigationService.NavigateToAsync("EditProjectView", parameters);
        }

        private bool _isSelected;

        public string Name { get; set; }
        public string Description { get; set; }

        public int Id { get; set; }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }

    }
}