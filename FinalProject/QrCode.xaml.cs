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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for QrCode.xaml
    /// </summary>
    public partial class QrCode : Page
    {
        public QrCode()
        {
            InitializeComponent();
        }

        private void BackCrt(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
            this.NavigationService.GoBack();
        }
    }
}
