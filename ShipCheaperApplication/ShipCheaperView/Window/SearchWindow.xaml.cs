using System.ComponentModel;
using System.Windows;

namespace ShipCheaperView.Window
{
    public partial class SearchWindow : System.Windows.Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
