using EgzaminS22323.DTOs;
using EgzaminS22323.Models;
using Microsoft.EntityFrameworkCore;

namespace EgzaminS22323.Services
{
    public class DbService : IDbService
    {
        private readonly Context context;

        public DbService(Context context)
        {
            this.context = context;
        }
        public async Task<ProjectDTO> getProjectInfo(int id) {
            Project project = await context.Projects.FindAsync(id);
            if (project == null)
            {
               
            }
            ProjectDTO projectDTO = await context.Projects.Where(e => e.IdTeam == id)
                .Select(e => new ProjectDTO
                {
                    ProjectName = e.Name,
                    Tasks = e.Tasks.Select(e => new TaskDTO
                    {
                        TaskName = e.Name,
                        Description = e.Description,
                        Deadline = e.Deadline,
                        TaskType = e.ITaskTypeNavigation.Name
                    }).OrderByDescending(e => e.Deadline)

                }).FirstAsync();

            return projectDTO;   
        }

        public async System.Threading.Tasks.Task addTask(AddTaskRequest task)
        {

            var type = context.TaskTypes.Select(e => e.IdTaskType == task.taskType.IdTaskType);

            if (type == null)
            {
                
                    await context.AddAsync(new TaskType
                    {
                        IdTaskType = task.taskType.IdTaskType,
                        Name = task.taskType.Name
                    });
                await context.SaveChangesAsync();
            }
 


            await context.AddAsync(new Models.Task
            {
                Name = task.Name,
                Description = task.Description,
                Deadline = task.Deadline,
                IdTeam = task.IdTeam,
                IdAssignedTo = task.IdAssignedTo,
                IdCreator = task.IdCreator,
                IdTaskType = task.taskType.IdTaskType
            });


            await context.SaveChangesAsync();
        }
    }
}
