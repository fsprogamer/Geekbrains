using System.Windows;

namespace StringFormat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int Salary { get; set; }
    }
}
