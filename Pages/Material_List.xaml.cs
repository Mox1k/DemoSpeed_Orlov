using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Material_List.xaml
    /// </summary>
    public partial class Material_List : Page
    {
        public Material_List()
        {
            InitializeComponent();

            DGridStorage.ItemsSource = ApplicationDbContext.GetContext().Building_Materials.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
