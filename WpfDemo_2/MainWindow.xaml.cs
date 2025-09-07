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
using WpfDemo_2.Data;

namespace WpfDemo_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "John", Age = 30 },
            new Person{Name = "Marco", Age = 20 },
            new Person{Name = "Maria", Age = 40 },
            new Person{Name = "Scott", Age = 35 },
            new Person{Name = "Lucas", Age = 27 },
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}