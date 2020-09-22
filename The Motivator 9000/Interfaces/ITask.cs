namespace The_Motivator_9000.Interfaces
{
    interface ITask
    {
        public string Name { get; set; }

        public string Description { get; set; }

        bool IsOverdue();
    }
}
