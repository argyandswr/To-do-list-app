using finalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("To-Do List Menu:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Add Priority Task");
            Console.WriteLine("3. Add Recurring Task");
            Console.WriteLine("4. Mark Task as Done");
            Console.WriteLine("5. Display All Tasks");
            Console.WriteLine("6. Display Pending Tasks");
            Console.WriteLine("7. Display Completed Tasks");
            Console.WriteLine("8. Exit");
            Console.WriteLine("==============================================");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask(taskManager);
                    break;
                case 2:
                    AddPriorityTask(taskManager);
                    break;
                case 3:
                    AddRecurringTask(taskManager);
                    break;
                case 4:
                    MarkTaskAsDone(taskManager);
                    break;
                case 5:
                    taskManager.DisplayTasks();
                    break;
                case 6:
                    taskManager.DisplayTasks(false);
                    break;
                case 7:
                    taskManager.DisplayTasks(true);
                    break;
                case 8:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddTask(TaskManager taskManager)
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter due date (yyyy-mm-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        finalProject.Task task = new finalProject.Task(title, description, dueDate);
        taskManager.AddTask(task);
    }

    static void AddPriorityTask(TaskManager taskManager)
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter due date (yyyy-mm-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter priority (1-5): ");
        int priority = int.Parse(Console.ReadLine());

        PriorityTask task = new PriorityTask(title, description, dueDate, priority);
        taskManager.AddTask(task);
    }

    static void AddRecurringTask(TaskManager taskManager)
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter due date (yyyy-mm-dd): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter recurrence interval (in days): ");
        int recurrenceInterval = int.Parse(Console.ReadLine());

        RecurringTask task = new RecurringTask(title, description, dueDate, recurrenceInterval);
        taskManager.AddTask(task);
    }

    static void MarkTaskAsDone(TaskManager taskManager)
    {
        Console.Write("Enter the title of the task to mark as done: ");
        string title = Console.ReadLine();

        foreach (var task in taskManager.Tasks)
        {
            if (task.Title == title)
            {
                task.MarkAsDone();
                Console.WriteLine("Task marked as done.");
                return;
            }
        }

        Console.WriteLine("Task not found.");
    }
}
