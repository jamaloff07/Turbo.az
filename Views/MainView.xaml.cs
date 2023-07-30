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
        private string selectedModel;



        private viewModel viewModel;

        public MainView()
        {
            InitializeComponent();

        viewModel = new viewModel();
            DataContext = viewModel;
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
                }

                if (!string.IsNullOrEmpty(viewModel.SelectedMarka) && !string.IsNullOrEmpty(viewModel.SelectedModel))
                {
                    List<Image> imagesToRemove = new List<Image>();
                    foreach (UIElement element in imageStackPanel.Children)
                    {
                        if (element is Image image && image != clickedImage)
                        {
                            imagesToRemove.Add(image);
                        }
                    }

                    foreach (Image image in imagesToRemove)
                    {
                        imageStackPanel.Children.Remove(image);
                    }
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
            }
        }



        private void Model_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string selectedModel = comboBox.SelectedItem.ToString();


                if (viewModel != null)
                {
                    string imageSource = GetImageSourceByModel(selectedModel);

                    selectedModelImage.Source = new BitmapImage(new Uri(imageSource, UriKind.RelativeOrAbsolute));

                    imageStackPanel.Children.Clear();
                    Image selectedImage = new Image
                    {
                        Source = new BitmapImage(new Uri(imageSource, UriKind.RelativeOrAbsolute)),
                        Width = 154,
                        Height = 108,
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top
                    };
                    selectedImage.MouseLeftButtonDown += CarImage_Click;
                    selectedImage.Tag = selectedModel;
                    imageStackPanel.Children.Add(selectedImage);
                }
            }
        }









        private string GetImageSourceByModel(string model)
        {

            switch (model)
            {
                case "E320":
                    return "/Image/4goz.jpg";
                case "S300":
                    return "/Image/sessot.jpg";
                case "G-63":
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
                case "Priora":
                    return "/Image/priora.jpg";
       
                case "prius":
                    return "/Image/prius.jpg";

                case "e36":
                    return "/Image/e36.jpg";

                case "595":
                    return "/Image/abart.jpg";
                default:

                    return "";
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