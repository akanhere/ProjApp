using Microsoft.EntityFrameworkCore;
using ProjectManagementApp.Data;
using ProjectManagementApp.Models;
using System.Linq;

public class DataService : IDataService
{
    private readonly AppDbContext _context;

    public DataService(AppDbContext context)
    {
        _context = context;
        _context.Database.Migrate();

        var prj = new Project { Description = "Test", Name = "Test" };
        if (!_context.Projects.Any())
        {
            _context.Projects.Add(prj);
            _context.SaveChanges();
        }
    }
    public async Task<List<Project>> GetProjectsAsync()
    {
        return await _context.Projects.ToListAsync();
    }


    public async Task UpdateProjectAsync(Project project)
    {
        _context.Projects.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task AddProjectAsync(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProjectAsync(Project project)
    {
        var projectToDelete = await _context.Projects.FindAsync(project.ProjectId);
        if (projectToDelete != null)
        {
            _context.Projects.Remove(projectToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
