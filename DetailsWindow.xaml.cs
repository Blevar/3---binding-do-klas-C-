using System;
using System.Collections;
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

namespace _3___binding_do_klas_C_
{
    /// <summary>
    /// Logika interakcji dla klasy DetailsWindow.xaml
    /// </summary>

    public partial class DetailsWindow : Window
    {
        
        public DetailsWindow(Film film)
        {                
            InitializeComponent();
            DataContext = film;           
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> nosniki = Enum.GetNames(typeof(Nosnik)).ToList();
            var combo = sender as ComboBox;
            combo.ItemsSource = nosniki;
            combo.SelectedIndex = combo.Items.IndexOf(((Film)DataContext).Nosnik.ToString());
        }

        private void ComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var selectedComboItem = sender as ComboBox;
            string name = selectedComboItem.SelectedItem as string;            
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
