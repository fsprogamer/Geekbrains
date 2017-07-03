using System.Collections.Generic;
using System.Windows;

namespace GridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Employee> items = new List<Employee>();
            items.Add(new Employee() { Name = "Петя", Age = 42, Salary = 25000 });
            items.Add(new Employee() { Name = "Коля", Age = 39, Salary = 45000 });
            items.Add(new Employee() { Name = "Иван", Age = 7, Salary = 33000 });
            lvEmployee.ItemsSource = items;
        }
    }
    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }
    }
}
