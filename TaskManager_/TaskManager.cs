using System;
using System.Collections.Generic;

namespace TaskManager_
{
    class TaskManager
    {
        public List<Task> tasks = new List<Task>();
        public int CountTasks { get; private set; }
        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task was created");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }
        public void DeleteTask(int number)
        {
            if (number >= 0 && number < tasks.Count)
            {
                tasks.RemoveAt(number);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Task was deleted");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Task not found");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void ShowTasks()
        {
            foreach (var task in tasks)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                task.ShowName();
                Console.ForegroundColor = ConsoleColor.White;
                task.ShowDescription();
                task.ShowTimeCreated();
                task.ShowCompletedAt();
                
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}
