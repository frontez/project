using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using neftproject.Models;
using System.Collections.ObjectModel;
using neftproject.Commands;
using System.Windows.Media;
using System.Windows;

namespace neftproject.ViewModels
{
    class MainViewModel : ViewModelBase
    {

        public ObservableCollection<WellViewModel> WellsList { get; set; }

        public MainViewModel(List<Well> wells)
        {
            WellsList = new ObservableCollection<WellViewModel>(wells.Select(w => new WellViewModel(w)));
        }

   


    }
}
