namespace DotNetCoreSqlDb.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public required string TaskName { get; set; } // Додаємо required
        public bool IsComplete { get; set; }
    }
}
