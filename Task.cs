using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    using System;
    using System.Collections.Generic;

    interface ITask
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime DueDate { get; set; }
        bool Status { get; }
        void MarkAsDone();
        void UpdateTask(string title, string description, DateTime dueDate);
        void DisplayTaskDetails();
    }

    class Task : ITask
    {
        private string _title;
        private string _description;
        private DateTime _dueDate;
        private bool _status;

        public Task(string title, string description, DateTime dueDate)
        {
            _title = title;
            _description = description;
            _dueDate = dueDate;
            _status = false; // False berarti belum selesai
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public bool Status
        {
            get { return _status; }
        }

        public void MarkAsDone()
        {
            _status = true;
        }

        public void UpdateTask(string title, string description, DateTime dueDate)
        {
            _title = title;
            _description = description;
            _dueDate = dueDate;
        }

        public virtual void DisplayTaskDetails()
        {
            Console.WriteLine($"Title: {Title}, Description: {Description}, Due Date: {DueDate}, Status: {(Status ? "Done" : "Pending")}");
        }
    }

}
