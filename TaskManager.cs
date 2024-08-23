using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class TaskManager
    {
        private List<ITask> _tasks;

        public TaskManager()
        {
            _tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(ITask task)
        {
            _tasks.Remove(task);
        }

        public void DisplayTasks()
        {
            foreach (var task in _tasks)
            {
                task.DisplayTaskDetails();
                Console.WriteLine();
            }
        }

        public void DisplayTasks(bool status)
        {
            foreach (var task in _tasks)
            {
                if (task.Status == status)
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine();
                }
            }
        }

        public List<ITask> Tasks
        {
            get { return _tasks; }
        }
    }

}
