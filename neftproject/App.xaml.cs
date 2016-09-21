using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using neftproject.Models;
using neftproject.ViewModels;
using neftproject;

namespace neftproject
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Well> wells = new List<Well>()
            {
                new Well("Скважина 1", 1790, 766, 3),
                new Well("Скважина 2", 2650, 802, 4),
                new Well("Скважина 3", 3102, 787, 5)
            };


            
            MainWindow view = new MainWindow(); // создали View
            MainViewModel viewModel = new ViewModels.MainViewModel(wells); // Создали ViewModel
            view.DataContext = viewModel ; // положили ViewModel во View в качестве DataContext
            view.Show();
            



        }

    }
}
