namespace EgzaminS22323.Models
{
    public class TaskType
    {
        public int IdTaskType { get; set; }
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
