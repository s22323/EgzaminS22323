namespace EgzaminS22323.Models
{
    public class Task
    {
        public int IdTask { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int IdTeam { get; set; }
        public int IdTaskType { get; set; }
        public int IdAssignedTo { get; set; }
        public int IdCreator { get; set; }

        public virtual Project IProjectNavigation { get; set; }
        public virtual TaskType ITaskTypeNavigation { get; set; }
        public virtual TeamMember IAssignedToNavigation { get; set; }
        public virtual TeamMember ICreatorNavigation { get; set; }

    }
}
