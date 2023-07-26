using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Command;
using WpfApp3.Model;
using WpfApp3.Views;

 

 

namespace WpfApp16.ViewModels
{
    public class MainViewModel
    {
        public ICommand? NewWindow { get; set; }

 

 

        public ObservableCollection<string> markaNames { get; set; }
        public ObservableCollection<string> modelNames { get; set; }
        public ObservableCollection<string> yearNames { get; set; }
        public string SelectedMarka { get; set; }

 

        public MainViewModel()
        {
            markaNames = new ObservableCollection<string>
            {

 

                "Mercedes",
                "BMW",
                "Toyota",
                "Wolksvagen",
                "dodge",
                "vaz",
                "lada",

 

 

            };
            modelNames = new ObservableCollection<string>
            {
                "4 goz",
                "e60",
                "camry",
                "challenger",
                "sessot",
                "2107",
                "brabus",
                "tuareg",
                "priora",
            };
        }

 

    }
}