using System;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task("First Task", "This is the first task");
            Console.WriteLine($"Task: {task.Title}, Completed: {task.IsCompleted}");
            task.Complete();
            Console.WriteLine($"Task: {task.Title}, Completed: {task.IsCompleted}");
        }
    }
}
