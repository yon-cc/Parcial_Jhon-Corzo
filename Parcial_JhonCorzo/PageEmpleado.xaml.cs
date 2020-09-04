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

namespace Parcial_JhonCorzo
{
    /// <summary>
    /// Interaction logic for PageEmpleado.xaml
    /// </summary>
    public partial class PageEmpleado : Page
    {
        public PageEmpleado()
        {
            InitializeComponent();

            comboBoxBread.Items.Add("Aliñeado");
            comboBoxBread.Items.Add("No aliñeado");
            comboBoxBread.Items.Add("Especial");

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new PageLogIn());
        }
    }
}
