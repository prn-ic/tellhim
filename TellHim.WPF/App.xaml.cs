using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TellHim.WPF.ViewModels;

namespace TellHim.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(homeViewModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
        
    }
}
