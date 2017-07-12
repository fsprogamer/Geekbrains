using System;
using System.Windows;

namespace WcfClient
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.Service1Client service = new ServiceReference.Service1Client();
            try
            {
                resultTextBlock.Text += service.calculateDays(Convert.ToInt32(dayTextBox.Text),
                                                             Convert.ToInt32(monthTextBox.Text),
                                                             Convert.ToInt32(yearTextBox.Text)).ToString();
            }
            catch(Exception)
            {

            }
        }
    }
}
