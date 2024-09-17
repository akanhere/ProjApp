using ProjectManagementApp.Models;
using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectManagementApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<ProjectViewModel> Projects { get; set; }
        public ICommand DeleteSelectedCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand AddProjectCommand { get; }


        public HomeViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService, dataService)
        {
            Projects = new ObservableCollection<ProjectViewModel>();
            DeleteSelectedCommand = new Command(async () => await DeleteSelected());
            //EditCommand = new Command<ProjectViewModel>(async (project) => await EditProject(project));
            EditCommand = new Command(async () => await EditProject());
            AddProjectCommand = new Command(async () => await AddProject());



            // Load projects from the database
            LoadProjects();


        }

        override public async Task InitializeAsync()
        {
            await base.InitializeAsync();
            LoadProjects();
        }

        private async void LoadProjects()
        {
            var projects = await DataService.GetProjectsAsync();
            foreach (var project in projects)
            {
                Projects.Add(new ProjectViewModel(NavigationService, DataService)
                {
                    Name = project.Name,
                    Description = project.Description,
                    Id = project.ProjectId
                });
            }
        }

        private async Task AddProject()
        {
            // Navigate to the add project page
            await NavigationService.NavigateToAsync("AddProjectView");
        }

        private async Task EditProject(/*ProjectViewModel project*/)
        {
            // Navigate to the edit page with the selected project
            //var parameters = new Dictionary<string, object>
            //{
            //    { "project", project }
            //};
            await NavigationService.NavigateToAsync("EditProjectView");
        }

        private async Task DeleteSelected()
        {
            var selectedProjects = Projects.Where(p => p.IsSelected).ToList();
            foreach (var projectViewModel in selectedProjects)
            {
                var project = new Project
                {
                    Name = projectViewModel.Name,
                    Description = projectViewModel.Description,
                    ProjectId = projectViewModel.Id
                };
                await DataService.DeleteProjectAsync(project);
                Projects.Remove(projectViewModel);
            }
        }
    }
}
