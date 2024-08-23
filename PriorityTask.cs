using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class PriorityTask : Task
    {
        public int Priority { get; set; }

        public PriorityTask(string title, string description, DateTime dueDate, int priority)
            : base(title, description, dueDate)
        {
            Priority = priority;
        }

        // Override virtual method dari class Task
        public override void DisplayTaskDetails()
        {
            base.DisplayTaskDetails();
            Console.WriteLine($"Priority: {Priority}");
        }
    }
}
