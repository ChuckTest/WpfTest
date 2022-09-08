using System.Windows;

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        Person person = new Person { Name = "Salman", Age = 26 };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);
        }
    }

    public class Person
    {

        public string Name
        {
            get;
            set;
        }
        
        public double Age
        {
            get;
            set;
        }

    }
}
