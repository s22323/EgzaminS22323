namespace EgzaminS22323.Models
{
    public class Project
    {

        public int IdTeam { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }

        public ICollection<Task> Tasks { get; set; }


    }
}
