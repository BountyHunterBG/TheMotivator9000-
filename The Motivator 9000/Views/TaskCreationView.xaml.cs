using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using The_Motivator_9000.Interfaces;
using The_Motivator_9000.Models;

namespace The_Motivator_9000.Views
{
    
    public partial class TaskCreationView : Page
    {
        private ObservableCollection<ITask> tasks;

        public TaskCreationView()
        {
            tasks = new ObservableCollection<ITask>();
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPageView(tasks), UriKind.Relative);
        }

        private void CreateDailyTask(object sender, RoutedEventArgs e)
        {
            tasks.Add(new DailyTask(DailyTask.Text, DailyTaskDescription.Text));
        }
    }
}
