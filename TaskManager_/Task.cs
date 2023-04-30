using System;

namespace TaskManager_
{
    class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? CompletedAt { get; private set; } // Nullable<DateTime>
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public void SetTimeCompleted(DateTime completedAt)
        {
            CompletedAt = completedAt;
        }
        public void ShowName()
        {
            Console.WriteLine($"Name: {Name}");
        }
        public void ShowDescription()
        {
            Console.WriteLine($"Desciption: \n{Description}");
        }
        public void ShowTimeCreated()
        {
            Console.WriteLine($"TimeCreated: {CreatedAt}");
        }
        public void ShowCompletedAt()
        {
            if (CompletedAt != null)
            {
                Console.WriteLine($"Completed at: {CompletedAt}");
            }
            else
            {
                Console.WriteLine("Task is not completed yet");
            }
        }
    }
}
	

