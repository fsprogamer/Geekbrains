using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BindingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding();

            binding.ElementName = "txtValue"; // элемент-источник
            binding.Path = new PropertyPath("Text"); // свойство элемента-источника
            mirrorTextBlock.SetBinding(TextBlock.TextProperty, binding); // установка привязки для элемента-приемника
        }
    }
}
