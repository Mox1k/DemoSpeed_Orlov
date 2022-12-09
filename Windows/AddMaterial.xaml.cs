using DemoSpeed_Orlov.Data;
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
using System.Windows.Shapes;

namespace DemoSpeed_Orlov.Windows
{
    /// <summary>
    /// Interaction logic for AddMaterial.xaml
    /// </summary>
    public partial class AddMaterial : Window
    {
        Material_List_Window _window;
        public AddMaterial(Material_List_Window window)
        {
            InitializeComponent();
            _window = window;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                try
                {
                    context.Building_Materials.Add(new Building_Materials()
                    {
                        Material_Number = Convert.ToInt32(MaterialNumber.Text),
                        Material_Name = MaterialName.Text,
                        Measure_Unit = UnitOfMeasureBox.Text,
                        Remains = Convert.ToInt32(Remains.Text),
                        Storage = Convert.ToInt32(WarehouseBox.Text),
                    }); ;
                    context.SaveChanges();
                    _window.RefreshMaterials();
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так при добавлении!");
                }
            }
            this.Close();
        }
    }
}
