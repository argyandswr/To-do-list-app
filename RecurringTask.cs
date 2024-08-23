using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class RecurringTask : Task
    {
        public int RecurrenceInterval { get; set; } // Dalam hari

        public RecurringTask(string title, string description, DateTime dueDate, int recurrenceInterval)
            : base(title, description, dueDate)
        {
            RecurrenceInterval = recurrenceInterval;
        }

        // Override virtual method dari class Task
        public override void DisplayTaskDetails()
        {
            base.DisplayTaskDetails();
            Console.WriteLine($"Recurs every {RecurrenceInterval} days");
        }
    }
}
