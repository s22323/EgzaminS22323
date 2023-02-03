using EgzaminS22323.Models;

namespace EgzaminS22323.DTOs
{
    public class AddTaskRequest
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime Deadline { get; set; }
        public int IdTeam { get; set; }
        public int IdAssignedTo { get; set; }
        public int IdCreator { get; set; }
        public TaskType taskType { get; set; }
    }
}
