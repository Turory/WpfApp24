using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Catalog catalogPage = new Catalog();
        About aboutPage = new About();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(catalogPage);

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(catalogPage);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(aboutPage);
        }
    }
}