using Model.Movie;
using ShipCheaperView.Window;
using System.Windows;
using ViewModel;
using ViewModel.InterfaceViewModel;

namespace ShipCheaperView
{
    public partial class App : Application
    {
        private readonly MovieModel model = new MovieModel();
        private IMainViewModel viewModel /* = new OnlyViewViewModel() */;
        private SearchWindow searchWind /* = new SearchWindow() */;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            searchWind = new SearchWindow();

            viewModel = new MainViewModel(model);

            searchWind.DataContext = viewModel;
            MainWindow = searchWind;
            ShutdownMode = ShutdownMode.OnMainWindowClose;
            MainWindow.Show();
        }
    }
}
