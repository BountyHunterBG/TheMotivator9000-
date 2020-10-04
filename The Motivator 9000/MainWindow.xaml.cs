using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using The_Motivator_9000.Views;

namespace The_Motivator_9000
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Navigate(new MainPageView());
        }
    }
}
