using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Command;
using WpfApp3.Model;
using WpfApp3.Views;





namespace WpfApp16.ViewModels
{
    public class viewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> markaNames { get; set; }
        public ObservableCollection<string> modelNames { get; set; }

        private string selectedMarka;
        public string SelectedMarka
        {
            get { return selectedMarka; }
            set
            {
                if (selectedMarka != value)
                {
                    selectedMarka = value;
                    OnPropertyChanged(nameof(SelectedMarka));
                    // ModelNames'i seçilen markaya göre güncelleyin.
                    UpdateModelNames();
                }
            }
        }

        public viewModel()
        {
            // Burada marka ve model isimlerini ekleyin
            markaNames = new ObservableCollection<string>
            {
                "Mercedes",
                "BMW",
                "Toyota",
                "Wolksvagen",
                "dodge",
                "vaz",
                "lada"
            };

            modelNames = new ObservableCollection<string>();
        }

        private void UpdateModelNames()
        {
            // ModelNames'i, seçilen markaya göre güncelleyin.
            // Bu örnekte, seçilen markaya göre basit bir şekilde model isimlerini ekliyoruz.
            // Daha gerçek bir senaryoda, verilerinizi bir veri kaynağından almanız gerekebilir.
            modelNames.Clear();
            if (SelectedMarka == "Mercedes")
            {
                modelNames.Add("4 goz");
                modelNames.Add("sessot");
            }
            else if (SelectedMarka == "BMW")
            {
                modelNames.Add("e60");
            }
            // ... Diğer markalara göre ekleme yapabilirsiniz.
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}