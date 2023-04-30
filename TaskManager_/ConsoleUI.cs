using System;

namespace TaskManager_
{
    class ConsoleUI
    {
        private TaskManager taskManager;
        public ConsoleUI(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MENU");
            Console.WriteLine("--------------");
            Console.WriteLine("1. AddTask");
            Console.WriteLine("2. ShowTasks");
            Console.WriteLine("3. RemoveTask");
            Console.WriteLine("4. Exit");
            Console.WriteLine("----------------");
        }
        public void AddTask()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter name task");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter description task");
            Console.ForegroundColor = ConsoleColor.White;
            string description = Console.ReadLine();
            taskManager.AddTask(new Task(name, description));
        }
        public void DeleteTask()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter number task for delete");
            Console.ForegroundColor = ConsoleColor.White;
            int nameDeleteTask = Convert.ToInt32(Console.ReadLine());
            taskManager.DeleteTask(nameDeleteTask - 1);
        }
        public void ShowTasks()
        {
            taskManager.ShowTasks();
        }
        public void Run()
        {
            while(true)
            {
                ShowMenu();
                Console.WriteLine("Enter your doing");
                Console.ForegroundColor = ConsoleColor.White;
                int doing = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(doing)
                {
                    case 1:
                        {
                            AddTask();
                            break;
                        }
                    case 2:
                        {
                            ShowTasks();
                            break;
                        }
                    case 3:
                        {
                            DeleteTask();
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Exit..");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Undifined");
                            break;
                        }
                }
                if (doing == 4) break;
            }
        }
    }
}
