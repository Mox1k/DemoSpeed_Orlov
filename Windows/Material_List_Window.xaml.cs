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
    /// Interaction logic for Material_List_Window.xaml
    /// </summary>
    public partial class Material_List_Window : Window
    {
        public Material_List_Window()
        {
            InitializeComponent();

            DGridStorage.ItemsSource = _context.Building_Materials.ToList();

        }

        public static ApplicationDbContext _context = new ApplicationDbContext();

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Entity = DGridStorage.SelectedItem as Building_Materials;
                ApplicationDbContext.GetContext().Building_Materials.Remove(Entity);
                ApplicationDbContext.GetContext().SaveChanges();
                DGridStorage.ItemsSource = _context.Building_Materials.ToList();
                DGridStorage.Items.Refresh();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить материал!");
            }
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            EditMaterial editMaterial = new EditMaterial(_context, sender, this);
            editMaterial.ShowDialog();
        }

        public void RefreshMaterials()
        {
            DGridStorage.ItemsSource = _context.Building_Materials.ToList();
            DGridStorage.Items.Refresh();
        }

        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            AddMaterial material = new AddMaterial(this);
            material.ShowDialog();
        }
    }
}
