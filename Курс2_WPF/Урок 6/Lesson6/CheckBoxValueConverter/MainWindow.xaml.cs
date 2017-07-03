﻿using System;
using System.Windows;
using System.Windows.Data;

namespace CheckBoxValueConverter
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
     public class YesNoToBooleanConverter : IValueConverter
        {
                public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
                {
                        switch(value.ToString().ToLower())
                        {
                                case "yes":
                                case "true":
                                        return true;
                                case "no":
                                case "false":
                                        return false;
                        }
                        return false;
                }

                public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
                {
                        if(value is bool)
                        {
                                if((bool)value == true)
                                        return "yes";
                                else
                                        return "no";
                        }
                        return "no";
                }
        }
}
