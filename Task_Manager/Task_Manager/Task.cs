namespace TaskManager
{
    public class Task
    {
        // Свойства задачи
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        // Конструктор
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        // Метод для отметки задачи как выполненной
        public void Complete()
        {
            IsCompleted = true;
        }
    }
}
