using System;
using System.Collections.Generic;

namespace The_Motivator_9000.Models
{
    public class WeeklyTask : BaseTask
    {
        private List<DayOfWeek> daysOfTheWeek;
        private int streak;

        public WeeklyTask(string name, string description, List<DayOfWeek> daysOfTheWeek)
            : base(name, description)
        {
            foreach (var day in daysOfTheWeek)
            {
                DaysOfTheWeek.Add(day);
            }
        }

        public List<DayOfWeek> DaysOfTheWeek
        {
            get { return daysOfTheWeek; }
            set { daysOfTheWeek = value; }
        }

        public int Streak
        {
            get { return streak; }
            set { streak = value; }
        }



        public override bool IsOverdue()
        {
            DateTime currentDateTime = DateTime.Now;

            if (!DaysOfTheWeek.Contains(currentDateTime.DayOfWeek))
            {
                return true;
            }
            return false;
        }
    }
}
