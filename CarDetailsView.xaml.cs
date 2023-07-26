using System.Windows;
using static WpfApp3.Views.MainView;

namespace WpfApp3.Views
{
    public partial class CarDetailsView : Window
    {
        public CarDetailsView(CarInfo car)
        {
            InitializeComponent();
            DataContext = car;
        }

        public string ImageSource { get; set; }

    }
}