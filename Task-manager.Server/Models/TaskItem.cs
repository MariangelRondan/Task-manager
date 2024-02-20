namespace Task_manager.Server.Models
{
    public class TaskItem
    {
        public int TaskId { get; set; }


        public string? TaskName { get; set; }

        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public string? Priority { get; set; }
    }
}
