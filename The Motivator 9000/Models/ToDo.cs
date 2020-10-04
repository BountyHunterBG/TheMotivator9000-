using System;

namespace The_Motivator_9000.Models
{
    public class ToDo : BaseTask
    {   
        private DateTime deadline;

        public ToDo(string name, string description, DateTime deadline)
            : base(name, description)
        {
            Deadline = deadline;
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        public override bool IsOverdue()
        {
            DateTime currentDateTime = DateTime.Now;

            if (currentDateTime.Day > Deadline.Day 
                || currentDateTime.Date > Deadline.Date
                || currentDateTime.Year > Deadline.Year)
            {
                return true;
            }
            return false;
        }
    }
}
