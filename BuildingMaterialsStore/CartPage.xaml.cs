﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuildingMaterialsStore
{
    /// <summary>
    /// Логика взаимодействия для CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        public CartPage()
        {
            InitializeComponent();
        }

        private void cartbakery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void removecart_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void orderbutton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void gobackbutton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.framemain.GoBack();
        }

        private void cart_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
