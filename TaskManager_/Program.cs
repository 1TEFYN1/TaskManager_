using System;

namespace TaskManager_
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            ConsoleUI consoleUI = new(taskManager);
            consoleUI.Run();
        }
    }
}
