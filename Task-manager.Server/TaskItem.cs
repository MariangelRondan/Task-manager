namespace Task_manager.Server
{
    public class TaskItem
    {
        public int TaskId { get; set; }

        public required string TaskName { get; set; }

        public string? Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
