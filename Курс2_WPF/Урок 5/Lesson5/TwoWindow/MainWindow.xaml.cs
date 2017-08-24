﻿using System.Windows;

namespace TwoWindow
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
            SecondWindow secondWindow = new SecondWindow();            
            secondWindow.Show();
        }
    }
}
