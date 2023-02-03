using EgzaminS22323.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EgzaminS22323.Services
{
        public interface IDbService
    {
        public Task<ProjectDTO> getProjectInfo(int id);
        public Task addTask(AddTaskRequest task);
    }
}
