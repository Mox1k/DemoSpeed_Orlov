using DemoSpeed_Orlov.Windows;
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

namespace DemoSpeed_Orlov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AllData.NavigationService.Navigate(new Pages.Storage_List());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Material_List_Window subWindow = new Material_List_Window();
            subWindow.Show();
        }
    }
}
