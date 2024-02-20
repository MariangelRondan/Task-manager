using Microsoft.AspNetCore.Mvc;


namespace TaskManager.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private static readonly string[] Priorities = new[]
        {
            "High", "Medium", "Low"
        };

        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTasks")]
        public IEnumerable<TaskItem> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new TaskItem
            {
                TaskName = $"Task {index}",
                Description = $"Description for Task {index}",
                Priority = Priorities[index % Priorities.Length],
                DueDate = DateTime.Now.AddDays(index)
            })
            .ToArray();
        }
    }


}