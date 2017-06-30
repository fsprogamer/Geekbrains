using System.Windows;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Создаем первое окно
            MainWindow wnd = new MainWindow();
            if (e.Args.Length == 1)
                MessageBox.Show("Параметр: \n\n" + e.Args[0]);
            wnd.Show();
        }
    }
}
