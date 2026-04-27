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

namespace wpf_tut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> Contacts {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Contacts = new ObservableCollection<Contact>();
            //Contacts = [];
            DataContext = Contacts;
        }

        private void Add_Contacts(object sender, RoutedEventArgs e)
        {
            Opacity = 0.5;

            var addContactWindow = new AddContactWindow();
            if (addContactWindow.ShowDialog().Value)
            {
                Contacts.Add(addContactWindow.NewContact);
            }

            Opacity = 1;
        }

        private void Clear_Contacts(object sender, RoutedEventArgs e)
        {
            Contacts.Clear();
        }

        private void Menu_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Contact menager", "Pige 2026", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Menu_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}