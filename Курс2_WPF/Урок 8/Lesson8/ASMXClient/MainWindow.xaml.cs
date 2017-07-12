using System.Windows;

namespace ASMXClient
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
            ServiceReference.WebServiceSoapClient serviceClient = new ServiceReference.WebServiceSoapClient();
            string sum = serviceClient.Summ(textBox1.Text, textBox2.Text);
            textBlock.Text = sum;
        }
    }
}
