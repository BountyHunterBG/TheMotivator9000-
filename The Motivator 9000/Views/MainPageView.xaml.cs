using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using The_Motivator_9000.Interfaces;

namespace The_Motivator_9000.Views
{

    public partial class MainPageView : Page
    {
        private ObservableCollection<ITask> tasks;
        public MainPageView()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<ITask>();
            DataContext = new ObservableCollection<ITask>();
            TaskList.ItemsSource = Tasks;
        }

        public MainPageView(ObservableCollection<ITask> newTasks)
        {
            InitializeComponent();
            if (Tasks is null)
            {
                Tasks = new ObservableCollection<ITask>();
            }

            foreach (var item in newTasks)
            {
                Tasks.Add(item);
            }

            DataContext = new ObservableCollection<ITask>();
            TaskList.ItemsSource = Tasks;
        }
        public ObservableCollection<ITask> Tasks
        {
            get
            {
                return tasks;
            }
            set
            {
                tasks = value;
            }
        }


        private void OpenTaskCreator(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(@"Views\TaskCreationView.xaml", UriKind.Relative));
        }
    }
}
