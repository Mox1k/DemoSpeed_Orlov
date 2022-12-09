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
    /// Interaction logic for EditMaterial.xaml
    /// </summary>
    public partial class EditMaterial : Window
    {
        public static ApplicationDbContext _context;
        private Building_Materials _material;
        private Material_List_Window _window;

        public EditMaterial(ApplicationDbContext context, object o, Material_List_Window material_List_Window)
        {
            InitializeComponent();

            _window = material_List_Window;

            _material = (o as Button).DataContext as Building_Materials;

            _context = context;

            MaterialNameEdit.Text = _material.Material_Name;

            UnitOfMeasureBox.Text = _material.Measure_Unit;

            Remains.Text = Convert.ToString(_material.Remains);

            WarehouseBox.Text = Convert.ToString(_material.Storage);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(_material.Material_Name, "Хотите удалить материал?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                _context.Building_Materials.Remove(_material);
                _context.SaveChanges();
                _window.RefreshMaterials();
                this.Close();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _material.Material_Name = MaterialNameEdit.Text;
                _material.Measure_Unit = UnitOfMeasureBox.Text;
                _material.Remains = Convert.ToInt32(Remains.Text);
                _material.Storage = Convert.ToInt32(WarehouseBox.Text);

                _window.RefreshMaterials();
                _context.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так при редактировании!");
            }
        }
    }
}
