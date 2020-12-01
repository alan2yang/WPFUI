﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace P2
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

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    #region help class
    public enum Category
    {
        Bomber,
        Fighter
    }

    public enum State
    {
        Available,
        Locked,
        Unknown
    }

    public class Plane
    {
        public Category category { get; set; }
        public string Name { get; set; }
        public State state { get; set; }
    }

    public class CategoryToSourceConverter : IValueConverter
    {
        /// <summary>
        /// 将Category转换为uri
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Category c = (Category)value;
            switch (c)
            {
                case Category.Bomber:
                    return "/Resources/Images/轰炸机.png";
                case Category.Fighter:
                    return "/Resources/Images/战斗机.png";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StateToNullableBoolConverter : IValueConverter
    {
        /// <summary>
        /// 将State转换为bool?
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State s = (State)value;
            switch (s)
            {
                case State.Available:
                    return true;
                case State.Locked:
                    return false;
                case State.Unknown:
                default:
                    return null;
            }
        }

        /// <summary>
        /// 将bool?转换为State
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nb = (bool?)value;
            switch (nb)
            {
                case true:
                    return State.Available;
                case false:
                    return State.Locked;
                case null:
                default:
                    return State.Unknown;
            }
        }
    }
    #endregion

}
