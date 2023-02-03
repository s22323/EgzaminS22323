using EgzaminS22323.DTOs;
using EgzaminS22323.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EgzaminS22323.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IDbService dbService;

        public TasksController(IDbService dbService)
        {
            this.dbService = dbService;
        }

        [HttpGet("projects/{id}")]
        public async Task<IActionResult> getProjects([FromRoute] int id)
        {
            var project = await dbService.getProjectInfo(id);
            return Ok(project);
        }

        [HttpPost("tasks")]
        public async Task<IActionResult> addTask([FromBody] AddTaskRequest request)
        {
            await dbService.addTask(request);
            return Ok();
        }
    }
}
