using System.Windows.Controls;

namespace ShipCheaperView.UC
{
    public partial class MovieListUC : UserControl
    {
        public MovieListUC()
        {
            InitializeComponent();

            var dc = DataContext;

            //image = (BitmapImage)Resources["image"];
        }

        private ProxyImage proxy;

        private void uc_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var dc = DataContext;

            // Resources["image"] = image = new BitmapImage(((IMoviesList)dc).ImageDefault);

            proxy = (ProxyImage)Resources["proxy"];

        }
    }
}
