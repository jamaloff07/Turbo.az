using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp16.ViewModels;
using WpfApp3.Command;

namespace WpfApp3.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void CarImage_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            if (clickedImage != null && clickedImage.Tag is string carTag)
            {
                CarInfo selectedCar = GetCarInfoByTag(carTag);
                if (selectedCar != null)
                {
                    CarDetailsView carDetailsView = new CarDetailsView(selectedCar);
                    carDetailsView.Show();
                }
            }
        }

        private CarInfo GetCarInfoByTag(string carTag)
        {
            // Burada seçilen araba bilgilerini doldurun ve geri döndürün.
            // Örnek olarak, selectedCar nesnesine CarInfo sınıfında veri ataması yapılmalıdır.
            CarInfo selectedCar = new CarInfo();
            // ...
            return selectedCar;
        }

        private void Marka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MainViewModel viewModel)
            {
                viewModel.modelNames.Clear();

                switch (viewModel.SelectedMarka)
                {
                    case "Mercedes":
                        viewModel.modelNames.Add("4 goz");
                        viewModel.modelNames.Add("sessot");
                        viewModel.modelNames.Add("brabus");
                        break;
                    case "BMW":
                        viewModel.modelNames.Add("e60");
                        // BMW için diğer modelleri ekle...
                        break;
                    case "Toyota":
                        viewModel.modelNames.Add("camry");
                        // Toyota için diğer modelleri ekle...
                        break;
                    case "Wolksvagen":
                        viewModel.modelNames.Add("tuareg");
                        // Wolksvagen için diğer modelleri ekle...
                        break;
                    case "dodge":
                        viewModel.modelNames.Add("challenger");
                        // Dodge için diğer modelleri ekle...
                        break;
                    case "vaz":
                        viewModel.modelNames.Add("2107");
                        // Dodge için diğer modelleri ekle...
                        break;
                    case "lada":
                        viewModel.modelNames.Add("priora");
                        // Dodge için diğer modelleri ekle...
                        break;
                    default:
                        break;
                }
            }
        }

        public class CarInfo
        {
            public string? Model { get; set; }
            public string? Motor { get; set; }
            public string? Year { get; set; }
            public string? Kilometers { get; set; }
            public string? Price { get; set; }
            public string? Color { get; set; }
            public string? ImageSource { get; internal set; }
            public string? about { get; set; }
        }
    }
}
