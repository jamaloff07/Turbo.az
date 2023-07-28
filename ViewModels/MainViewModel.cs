// MainViewModel.cs
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp3.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // Burada MainViewModel sınıfının içeriğini tanımlayın
        // Örnek olarak, aşağıdaki özellikleri ekleyin:



        public ICommand? NewWindow { get; set; }


        public ObservableCollection<string> markaNames { get; set; }
        public ObservableCollection<string> modelNames { get; set; }
        public ObservableCollection<string> yearNames { get; set; }

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
                    // Burada model ComboBox'ını doldurma işlemlerini gerçekleştirebilirsiniz.
                }
            }
        }

        // İhtiyaç duyarsanız diğer özellikleri de ekleyebilirsiniz.

        public MainViewModel()
        {
            Markalar = new ObservableCollection<string>
            {
                "Mercedes",
                "BMW",
                "Toyota",
                "Wolksvagen",
                "Dodge",
                "VAZ",
                "Lada"
                // Diğer markaları da buraya ekleyin...
            };

            Modeller = new ObservableCollection<string>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
