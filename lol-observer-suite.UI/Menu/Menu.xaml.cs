﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lol_observer_suite.UI.Menu
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
