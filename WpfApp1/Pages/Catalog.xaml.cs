using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        ObservableCollection<Drink> drinks = new ObservableCollection<Drink>();

        public Catalog()
        {
            InitializeComponent();

            drinks.Add(new Drink { Title = "Finsky Ice", Volume = 700, Strenght = 40});
            drinks.Add(new Drink { Title = "Nemiroff особая", Volume = 100, Strenght = 40});
            drinks.Add(new Drink { Title = "Jagermeister", Volume = 700, Strenght = 35});

            listDrinks.ItemsSource = drinks;
        }

        private void listDrinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listDrinks.SelectedItem is Drink b)
            {
                DataContext = b;
            }
        }

        private void listDrinks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listDrinks.SelectedItem is Drink b)
            {
                DrinkDetailsPage p = new DrinkDetailsPage(b);
                p.DataContext = b;
                NavigationService?.Navigate(p);
            }
        }
    }
}
