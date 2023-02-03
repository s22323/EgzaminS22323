namespace EgzaminS22323.DTOs
{
    public class ProjectDTO
    {
        public string ProjectName { get; set; }

        public IEnumerable<TaskDTO> Tasks { get; set; }

    }
}
