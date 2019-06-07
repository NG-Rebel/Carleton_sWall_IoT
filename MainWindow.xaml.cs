using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();   
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            HandClick.Visibility = Visibility.Hidden;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            HandClick.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new UserControlCreate();
                    GridMain.Children.Add(usc);
                    MessageBox.Show("hello");
                    break;
                default:
                    break;
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Close Application?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            int[] data = DatabaseAnalysis.GetGraphData("Temperature", "Node2");
            for (int i = 0; i<24; i++)
            {
                MessageBox.Show(data[i].ToString());
            }
            
        }

        private void ItemLibrary_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Page2();
        }

        private void ItemAzrieli_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Page3();
        }

        private void ItemComputer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Page1();
        }

        private void ItemTree_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Page4();
        }
    }
}