using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
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
        private string selectedModel;

        private List<string> imageSources = new List<string>(); 


        private viewModel viewModel;
        string adUrl = "https://arazmarket.az/";
        string adUrl1 = "https://arazmarket.az/";

        public MainView()
        {
            InitializeComponent();

        viewModel = new viewModel();
            DataContext = viewModel;
            Model_SelectionChanged(model, null);
 

            LoadAd(adUrl);
            LoadAd(adUrl1);

        }


        private void CarImage_Click(object sender, MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            if (clickedImage != null && clickedImage.Tag is string carTag)
            {
                CarInfo selectedCar = GetCarInfoByTag(carTag);
                if (selectedCar != null)
                {
                    CarDetailsView carDetailsView = new CarDetailsView(selectedCar);
                    carDetailsView.Show();

                    // Seçili arabayı viewModel'e atayarak, diğer bilgileri de güncellemek
                    viewModel.SelectedModel = selectedCar.Model;
                    viewModel.SelectedMarka = GetSelectedMarkaFromModel(selectedCar.Model);
                }
            }
        }
         
        private string GetSelectedMarkaFromModel(string selectedModel)
        {
            switch (selectedModel)
            {
                case "E320":
                case "S300":
                case "G-63":
                    return "Mercedes";
                case "e60":
                case "e36":
                    return "BMW";
                case "camry":
                case "prius":
                    return "Toyota";
                case "tuareg":
                    return "Wolksvagen";
                case "challenger":
                    return "dodge";
                case "2107": 
                    return "vaz";
                case "Priora":
                    return "lada";
                case "595":
                    return "Abarth";
                default:
                    return string.Empty;
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
                        Model = " Lada Priora",
                        Motor = " Motor: 1.6L Benzin",
                        Year = " İl: 2005",
                        Kilometers = " Yürüş: 150000",
                        Price = " Qiymet: 15000",
                        Color = " Reng: Qara",
                        about = " Haqqinda:  Ismayil mellimin masinina soz demek olmaz",
                        ImageSource = "/image/priora.jpg",
                    };
                    break;

                     
                case "tuareg":
                    selectedCar = new CarInfo
                    {
                        Model = " Wolksvagen Tuareg",
                        Motor = " Motor: 3.2L benzin",
                        Year = " İl: 2008",
                        Kilometers = " Yürüş: 180000",
                        Price = " Qiymet: 25000",
                        Color = " Reng: Qara",
                        about = " Haqqinda: hec bir problemi yoxdur normal\n sur omrunun axrina qeder usta uzu gorme",
                        ImageSource = "/Image/tuareg.jpg",
                    };
                    break;
                     
                case "E320":
                    selectedCar = new CarInfo
                    {
                        Model = " Mercedes e320",
                        Motor = " Motor: 3.2L benzin",
                        Year = " İl: 1999",
                        Kilometers = " Yürüş: 123000",
                        Price = " Qiymet: 10000",
                        Color = " Reng: Boz",
                        about = " Haqqinda: baki qebele ureyin isteyen kimi sur\n hec bir problemi yoxdu",
                        ImageSource = "/Image/4goz.jpg",
                    };
                    break;



                case "e60":
                    selectedCar = new CarInfo
                    {
                        Model = " BMW e60",
                        Motor = " Motor: 5.5L Benzin",
                        Year = " İl: 1999",
                        Kilometers = " Yürüş: 12000",
                        Price = " Qiymet: 25000",
                        Color = " Reng: Benovseyi",
                        about = " Haqqinda: sport purjun stage 1 yukseldilib \nhec bir problemi yoxdur",
                        ImageSource = "/Image/60kuza.jpg",
                    };
                    break;
                     
                case "camry":
                    selectedCar = new CarInfo
                    {
                        Model = " Toyota camry",
                        Motor = " Motor: 2.5L Benzin",
                        Year = " İl: 2022",
                        Kilometers = " Yürüş: 0",
                        Price = " Qiymet: 35000",
                        Color = " Reng: Ag",
                        about = " Haqqinda: cox rahat tam dayday masini bez problem",
                        ImageSource = "/Image/camry.jpg",
                    };
                    break;
                     
                case "2107":
                    selectedCar = new CarInfo
                    {
                        Model = " Vaz 2107",
                        Motor = " Motor: 1.3L Benzin",
                        Year = " İl: 1987",
                        Kilometers = " Yürüş: 200000",
                        Price = " Qiymet:  5000",
                        Color = "Reng: Ag",
                        about = "Haqqinda: problemzisdir axir qiymeti budu",
                        ImageSource = "/Image/07.jpg",
                    };
                    break;
 
                case "G-63":
                    selectedCar = new CarInfo
                    {
                        Model = " Mercedes G-63",
                        Motor = " Motor: 6.5L Benzin",
                        Year = " İl: 2021",
                        Kilometers = "Yürüyüş: 0",
                        Price = " Qiymet: 350000",
                        Color = " Reng: Boz",
                        ImageSource = "/image/qalikk.jpg",
                    };
                    break;
 
                case "S300":
                    selectedCar = new CarInfo
                    {
                        Model = " Mercedes S300",
                        Motor = " Motor: 5.5L Benzin",
                        Year = " İl: 1988",
                        Kilometers = " Yürüş: 200000",
                        Price = " Qiymet: 15000",
                        Color = " Reng: Qara",
                        about = " haqqinda - bilen bilir bu nece masindir alanada satanada allah\n xeyir versin",
                        ImageSource = "/image/sessot.jpg",
                    };
                    break;

                case "challenger":
                    selectedCar = new CarInfo
                    {
                        Model = " Dodge challenger",
                        Motor = " Motor: 6.5L Benzin",
                        Year = " İl: 2020",
                        Kilometers = " Yürüş: 0",
                        Price = " Qiymet: 60000",
                        Color = " Reng: Yaş asfalt",
                        ImageSource = "/image/dodge.jpg",
                    };
                    break;


                case "e36":
                    selectedCar = new CarInfo
                    {
                        Model = "BMW 320",
                        Motor = "Motor: 2.0 L",
                        Year = "İl: 1996",
                        Kilometers = "Yürüş: 400000 km",
                        Price = "Qiymet: 9900 AZN",
                        Color = "Reng: White",
                        ImageSource = "/image/e36.jpg",
                        about = "Haqqinda: Ideal veziyyetdedir Real alicilar narahat etsin",
                    };
                    break;


                case "prius":
                    selectedCar = new CarInfo
                    {
                        Model = "Toyota Prius",
                        Motor = "Motor: 1.5 L",
                        Year = "İl: 2008",
                        Kilometers = "Yürüş: 211,000 km",
                        Price = "Qiymet: 15,000 AZN",
                        Color = "Reng: White",
                        ImageSource = "/image/prius.jpg",
                        about = "Haqqinda: Butun masinlar size yol verecek",
                    };
                    break;

                case "595":
                    selectedCar = new CarInfo
                    {
                        Model = "Abarth 595",
                        Motor = "Motor: 1.4 L",
                        Year = "İl: 2017",
                        Kilometers = "Yürüş: 67,000 km",
                        Price = "Qiymet: 26,000 AZN",
                        Color = "Reng: Boz",
                        ImageSource = "/image/abart.jpg",
                        about = "Haqqinda: Butun masinlar size yol verecek",
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
                imageSources.Clear(); // Yeni bir marka seçildiğinde, imageSources listesini temizleyelim.

                switch (viewModel.SelectedMarka)
                {
                    case "Mercedes":
                        viewModel.modelNames.Add("E320");
                        viewModel.modelNames.Add("S300");
                        viewModel.modelNames.Add("G-63");
                        break;
                    case "BMW":
                        viewModel.modelNames.Add("e60");
                        viewModel.modelNames.Add("e36");
                        break;
                    case "Toyota":
                        viewModel.modelNames.Add("camry");
                        viewModel.modelNames.Add("prius");
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
                        viewModel.modelNames.Add("Priora");
                        break;
                    case "Abarth":
                        viewModel.modelNames.Add("595");
                        break;
                    default:
                        break;
                }

                // ModelComboBox'ın seçimini temizle
                model.SelectedIndex = -1;
                // Model_SelectionChanged olayını tetikleyerek yeni arabaları yükleyelim
                Model_SelectionChanged(model, null);
            }
        }

        private void Model_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string selectedModel = comboBox.SelectedItem.ToString();

                if (viewModel != null)
                {
                    List<string> newImageSources = GetImageSourcesByModel(selectedModel);

                    // Yeni model seçildiğinde, mevcut imageStackPanel'i temizleyelim
                    imageStackPanel.Children.Clear();

                    double xPosition = 0;
                    double yPosition = 30;
                    double xSpacing = 5;
                    double ySpacing = 5;

                    foreach (var imageSource in newImageSources)
                    {
                        Image selectedImage = new Image
                        {
                            Source = new BitmapImage(new Uri(imageSource, UriKind.RelativeOrAbsolute)),
                            Width = 154,
                            Height = 108,
                            Margin = new Thickness(5),
                            Tag = selectedModel
                        };

                        Canvas.SetLeft(selectedImage, xPosition);
                        Canvas.SetTop(selectedImage, yPosition);
                        imageStackPanel.Children.Add(selectedImage);

                        xPosition += selectedImage.Width + xSpacing;

                        if (xPosition + selectedImage.Width + xSpacing > 660)
                        {
                            xPosition = 0;
                            yPosition += selectedImage.Height + ySpacing;
                        }
                    }

                    imageSources.Clear();
                    imageSources.AddRange(newImageSources);
                }
            }
        }

        private List<string> GetImageSourcesByModel(string model)
        {

            switch (model)
            {
                case "E320":
                    imageSources.Add("/image/4goz.jpg");
                    imageSources.Add("/image/60kuza.jpg");
                    imageSources.Add("/image/e36.jpg");
                    break;
                case "S300":
                    imageSources.Add("/image/sessot.jpg");
                    imageSources.Add("/image/E320_2.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "G-63":
                    imageSources.Add("/image/qalikk.jpg");
                    imageSources.Add("/image/E320_2.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "e60":
                    imageSources.Add("/image/60kuza.jpg");
                    imageSources.Add("/image/e36.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "camry":
                    imageSources.Add("/image/camry.jpg");
                    imageSources.Add("/image/E320_2.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "2107":
                    imageSources.Add("/image/07.jpg");
                    imageSources.Add("/image/E320_2.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "challenger":
                    imageSources.Add("/image/dodge.jpg");
                    imageSources.Add("/image/E320_2.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "tuareg":
                    imageSources.Add("/image/tuareg.jpg");
                    imageSources.Add("/image/E320_2.jpg");
                    imageSources.Add("/image/E320_3.jpg");
                    break;
                case "Priora":
                    imageSources.Add("/Image/priora.jpg");
                    imageSources.Add("/Image/E320_2.jpg");
                    imageSources.Add("/Image/E320_3.jpg");
                    break;

                case "prius":
                    imageSources.Add("/Image/prius.jpg");
                    imageSources.Add("/Image/E320_2.jpg");
                    imageSources.Add("/Image/E320_3.jpg");
                    break;
                case "e36":
                    imageSources.Add("/Image/e36.jpg");
                    imageSources.Add("/Image/E320_2.jpg");
                    imageSources.Add("/Image/E320_3.jpg");
                    break;

                case "595":
                    imageSources.Add("/Image/abart.jpg");
                    imageSources.Add("/Image/E320_2.jpg");
                    imageSources.Add("/Image/E320_3.jpg");
                    break;
                default:

                    return null;
            }

            return imageSources;
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

        private void LoadAd(string url)
        {
            try
            {




            }
            catch (Exception ex)
            {
                // Reklam yüklenirken hata olursa burada işleme alınabilir.
                MessageBox.Show("Reklam yüklenirken bir hata oluştu: " + ex.Message);
            }



            try
            {
                // Reklamı yükle
                webBrowser1.Navigate(new Uri(url));
            }
            catch (Exception ex)
            {
                // Reklam yüklenirken hata olursa burada işleme alınabilir.
                MessageBox.Show("Reklam yüklenirken bir hata oluştu: " + ex.Message);
            }





        }

    }


}