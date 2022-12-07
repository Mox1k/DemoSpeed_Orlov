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
using DemoSpeed_Orlov.Data;


namespace DemoSpeed_Orlov.Pages
{
    /// <summary>
    /// Interaction logic for AllData.xaml
    /// </summary>
    public partial class Storage_List : Page
    {
        public Storage_List()
        {
            InitializeComponent();

            DGridStorage.ItemsSource = ApplicationDbContext.GetContext().Storages.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
