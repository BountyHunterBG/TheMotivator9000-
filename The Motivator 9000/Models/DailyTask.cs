using System;

namespace The_Motivator_9000.Models
{
    public class DailyTask : BaseTask
    {
        private DateTime deadline;
        private int streak;

        public DailyTask(string name, string description)
            : base(name, description)
        {
            Deadline = DateTime.Now;
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        public int Streak
        {
            get { return streak; }
            set { streak = value; }
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
