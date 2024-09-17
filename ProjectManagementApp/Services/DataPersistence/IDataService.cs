using ProjectManagementApp.Models;

public interface IDataService
{
    Task AddProjectAsync(Project project);

    Task<List<Project>> GetProjectsAsync();

    Task DeleteProjectAsync(Project project);

    Task UpdateProjectAsync(Project project);
}