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
using WpfApp3.Model;
using WpfApp3.ViewModels;


namespace WpfApp3.Views
{
    public partial class MainView : Window
    {



        private viewModel viewModel;

        public MainView()
        {
            InitializeComponent();

            viewModel = new viewModel();
            DataContext = viewModel;
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
            CarInfo selectedCar = null;



            switch (carTag)
            {
                case "Priora":
                    selectedCar = new CarInfo
                    {
                        Model = "Lada Priora",
                        Motor = "Motor: 1.6 L",
                        Year = "İl: 2010",
                        Kilometers = "Yürüş: 100,000 km",
                        Price = "Qiymet: 25,000 AZN",
                        Color = "Reng: Ag",
                        ImageSource = "/image/priora.jpg",
                        about = "Haqqinda: Priora hakkında bilgi...",
                    };
                    break;

                case "Tuareg":
                    selectedCar = new CarInfo
                    {
                        Model = "Wolksvagen Tuareg",
                        Motor = "Motor: 2.0 TDI",
                        Year = "İl: 2012",
                        Kilometers = "Yürüş: 80,000 km",
                        Price = "Qiymet: 40,000 AZN",
                        Color = "Reng: Qara",
                        ImageSource = "/Image/tuareg.jpg",
                        about = "Haqqinda: Tuareg hakkında bilgi...",
                    };
                    break;

                case "4Goz":
                    selectedCar = new CarInfo
                    {
                        Model = "Mercedes E290",
                        Motor = "Motor: 2.9 L",
                        Year = "İl:2015",
                        Kilometers = "Yürüş: 120,000 km",
                        Price = "Qiymet: 30,000 AZN",
                        Color = "Reng: White",
                        ImageSource = "/Image/4goz.jpg",
                        about = "Haqqinda: 4 Göz hakkında bilgi...",
                    };
                    break;


                case "e60":
                    selectedCar = new CarInfo
                    {
                        Model = "BMW E60",
                        Motor = "Motor: 2.0 L",
                        Year = "İl: 2008",
                        Kilometers = "Yürüş: 150,000 km",
                        Price = "Qiymet: 20,000 AZN",
                        Color = "Reng: Qara",
                        ImageSource = "/Image/60kuza.jpg",
                        about = "Haqqinda: e60 hakkında bilgi...",
                    };
                    break;

                case "camry":
                    selectedCar = new CarInfo
                    {
                        Model = "Toyota Camry",
                        Motor = "Motor: 2.5 L",
                        Year = "İl:2014",
                        Kilometers = "Yürüş: 90,000 km",
                        Price = "Qiymet: 35,000 AZN",
                        Color = "Reng: Silver",
                        ImageSource = "/Image/camry.jpg",
                        about = "HaqqindaCamry hakkında bilgi...",
                    };
                    break;

                case "2107":
                    selectedCar = new CarInfo
                    {
                        Model = "Lada VAZ 2107",
                        Motor = "Motor: 1.6 L",
                        Year = "İl: 2005",
                        Kilometers = "Yürüş: 180,000 km",
                        Price = "Qiymet: 12,000 AZN",
                        Color = "Reng: Green",
                        ImageSource = "/Image/07.jpg",
                        about = "HAqqinda: 2107 hakkında bilgi...",
                    };
                    break;

                case "brabus":
                    selectedCar = new CarInfo
                    {
                        Model = "Mercedes G-63",
                        Motor = "Motor: 4.0 L",
                        Year = "İl: 2018",
                        Kilometers = "Yürüş: 20,000 km",
                        Price = "Qiymet: 200,000 AZN",
                        Color = "Reng: Red",
                        ImageSource = "/image/qalikk.jpg",
                        about = "Haqqinda: Brabus hakkında bilgi...",
                    };
                    break;

                case "sessot":
                    selectedCar = new CarInfo
                    {
                        Model = "Mercedes S300",
                        Motor = "Motor: 3.0 L",
                        Year = "İl: 2016",
                        Kilometers = "Yürüş: 40,000 km",
                        Price = "Qiymet: 150,000 AZN",
                        Color = "Reng: Blue",
                        ImageSource = "/image/download.jpg",
                        about = "Haqqinda: Sessot hakkında bilgi...",
                    };
                    break;

                case "challenger":
                    selectedCar = new CarInfo
                    {
                        Model = "Dodge Challenger",
                        Motor = "Motor: 3.6 L",
                        Year = "İl: 2019",
                        Kilometers = "Yürüş: 15,000 km",
                        Price = "Qiymet: 180,000 AZN",
                        Color = "Reng: White",
                        ImageSource = "/image/dodge.jpg",
                        about = "Haqqinda: Challenger hakkında bilgi...",
                    };
                    break;


                default:
                    break;
            }

            return selectedCar;
        }


        private void Marka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is viewModel viewModel)
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
                        break;
                    case "Toyota":
                        viewModel.modelNames.Add("camry");
                        break;
                    case "Wolksvagen":
                        viewModel.modelNames.Add("tuareg");
                        break;
                    case "dodge":
                        viewModel.modelNames.Add("challenger");
                        break;
                    case "vaz":
                        viewModel.modelNames.Add("2107");
                        break;
                    case "lada":
                        viewModel.modelNames.Add("priora");
                        break;
                    default:
                        break;
                }
            }
        }
        private void Model_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string selectedModel = comboBox.SelectedItem.ToString();

                // Seçilen modele göre yapılacak işlemleri burada ekleyin

                // ViewModel'de tanımladığınız marka ve model listelerine buradan erişebilirsiniz:
                if (DataContext is viewModel viewModel)
                {
                    // Seçilen modele göre uygun resim yolunu belirleyin
                    string imageSource = GetImageSourceByModel(selectedModel);

                    // Seçilen modele göre resmi Image kontrolüne yükleyin
                    selectedModelImage.Source = new BitmapImage(new Uri(imageSource, UriKind.RelativeOrAbsolute));
                }
            }
        }

        private string GetImageSourceByModel(string model)
        {
            // Model adına göre uygun resim yolunu döndürün
            switch (model)
            {
                case "4 goz":
                    return "/Image/4goz.jpg";
                case "sessot":
                    return "/Image/download.jpg";
                case "brabus":
                    return "/Image/qalikk.jpg";
                case "e60":
                    return "/Image/60kuza.jpg";
                case "camry":
                    return "/Image/camry.jpg";
                case "2107":
                    return "/Image/07.jpg";
                case "challenger":
                    return "/Image/dodge.jpg";
                case "tuareg":
                    return "/Image/tuareg.jpg";
                case "priora":
                    return "/Image/priora.jpg";
                default:
                    return ""; // Varsayılan olarak boş resim yolu döndürün
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


        private void myImageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/red_text.png", UriKind.Relative);
            selectionText.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void myImageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/SlateGray_text.png", UriKind.Relative);

            selectionText.Foreground = new SolidColorBrush(Colors.SlateGray);

        }

        private void myImageButton1_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/red_text.png", UriKind.Relative);
            selectionText1.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void myImageButton1_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/SlateGray_text.png", UriKind.Relative);

            selectionText1.Foreground = new SolidColorBrush(Colors.SlateGray);

        }

        private void myImageButton2_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/red_text.png", UriKind.Relative);
            selectionText2.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void myImageButton2_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri textResourceUri = new Uri("/images/SlateGray_text.png", UriKind.Relative);

            selectionText2.Foreground = new SolidColorBrush(Colors.SlateGray);

        }

        private void ImageButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/RedHeart.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/red_text.png", UriKind.Relative);
            heartImage.Source = new BitmapImage(heartResourceUri);
            selectionTextt.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void ImageButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/heart.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/SlateGray_text.png", UriKind.Relative);
            heartImage.Source = new BitmapImage(heartResourceUri);
            selectionTextt.Foreground = new SolidColorBrush(Colors.SlateGray);
        }

        private void ImageButtonn_MouseEnter(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/RedUser.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/red_text.png", UriKind.Relative);
            userImage.Source = new BitmapImage(heartResourceUri);
            selectionTexttu.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void ImageButtonn_MouseLeave(object sender, MouseEventArgs e)
        {
            Uri heartResourceUri = new Uri("/Red_image/user.png", UriKind.Relative);
            Uri textResourceUri = new Uri("/Red_image/SlateGray_text.png", UriKind.Relative);
            userImage.Source = new BitmapImage(heartResourceUri);
            selectionTexttu.Foreground = new SolidColorBrush(Colors.SlateGray);
        }
    }
}