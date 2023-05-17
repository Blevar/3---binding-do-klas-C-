using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;

namespace _3___binding_do_klas_C_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private const string PathIO = "listaFilmow.xml";

        public ObservableCollection<Film> Filmy { get; } = new ObservableCollection<Film>();
        ListBox kolekcjaFilmow;

        public MainWindow()
        {
            DataContext = this;            
            InitializeComponent();
            kolekcjaFilmow = (ListBox)this.FindName("ListaFilmow");            
        }
        private void Dodaj(object sender, RoutedEventArgs e)
        {
            Film nowy = new Film();
            Filmy.Add(nowy);
            new DetailsWindow(nowy).Show();
        }

        private void Edytuj(object sender, RoutedEventArgs e)
        {
            new DetailsWindow((Film)kolekcjaFilmow.SelectedItem).Show();
        }

        private void Usun(object sender, RoutedEventArgs e)
        {
            Filmy.Remove((Film)kolekcjaFilmow.SelectedItem);
        }

        private void Importuj(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Film>));
                using (StreamReader reader = new StreamReader(PathIO))
                {
                    Filmy.Clear();
                    ObservableCollection<Film> importedFilmy = (ObservableCollection<Film>)serializer.Deserialize(reader);
                    foreach (Film film in importedFilmy)
                    {
                        Filmy.Add(film);
                    }
                }
                MessageBox.Show("Lista filmów została wczytana z pliku listaFilmow.xml.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas wczytywania listy filmów z pliku: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Exportuj(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Film>));
                using (StreamWriter writer = new StreamWriter(PathIO))
                {
                    serializer.Serialize(writer, Filmy);
                }
                MessageBox.Show("Lista filmów została zapisana do pliku listaFilmow.xml.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisywania listy filmów do pliku: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
