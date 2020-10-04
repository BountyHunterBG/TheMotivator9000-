using The_Motivator_9000.Interfaces;

namespace The_Motivator_9000.Models
{
    public abstract class BaseTask : BaseNotifyPropertyChanged, ITask
    {
        protected string name;
        protected string description;
        
        public BaseTask(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public abstract bool IsOverdue();
    }
}
