using System.Data;
using System.Windows;

namespace ADO
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public DataRow resultRow { get; set; } 
        public EditWindow(DataRow dataRow)
        {
            InitializeComponent();
            resultRow = dataRow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            resultRow["FIO"] = fIOTextBox.Text;
            resultRow["Birthday"] = birthdayTextBox.Text;
            resultRow["Email"] = emailTextBox.Text;
            resultRow["Phone"] = phoneTextBox.Text;
            DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
