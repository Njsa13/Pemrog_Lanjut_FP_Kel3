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
    /// Interaction logic for AddBilling.xaml
    /// </summary>
    public partial class AddBilling : Page
    {
        public AddBilling()
        {
            InitializeComponent();
        }

        GetSetData gtData = new GetSetData();

        private void BackAdd(object sender, RoutedEventArgs e)
        {
            var mainmenu = new MainMenu();
            NavigationService.Navigate(mainmenu);
        }

        private void Bill1(object sender, RoutedEventArgs e)
        {
            int Time = gtData.getTime(gtData.getFile());
            int price = 5000;
            int tempTime = Time + 1800;

            if (gtData.updateTime(gtData.getFile(), tempTime) && gtData.UpAndInsOdr(gtData.getFile(), "30 Menit", 1, price))
            {
                MessageBox.Show("Add Billing Successfully", "Add Billing Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                var mainmenu = new MainMenu();
                NavigationService.Navigate(mainmenu);
            }
            else
            {
                MessageBox.Show("Failed to Add Billing", "Add Billing Failed",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bill2(object sender, RoutedEventArgs e)
        {
            int Time = gtData.getTime(gtData.getFile());
            int price = 10000;
            int tempTime = Time + 3600;

            if (gtData.updateTime(gtData.getFile(), tempTime) && gtData.UpAndInsOdr(gtData.getFile(), "1 Jam", 1, price))
            {
                MessageBox.Show("Add Billing Successfully", "Add Billing Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                var mainmenu = new MainMenu();
                NavigationService.Navigate(mainmenu);
            }
            else
            {
                MessageBox.Show("Failed to Add Billing", "Add Billing Failed",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bill3(object sender, RoutedEventArgs e)
        {
            int Time = gtData.getTime(gtData.getFile());
            int price = 20000;
            int tempTime = Time + 7200;

            if (gtData.updateTime(gtData.getFile(), tempTime) && gtData.UpAndInsOdr(gtData.getFile(), "2 Jam", 1, price))
            {
                MessageBox.Show("Add Billing Successfully", "Add Billing Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                var mainmenu = new MainMenu();
                NavigationService.Navigate(mainmenu);
            }
            else
            {
                MessageBox.Show("Failed to Add Billing", "Add Billing Failed",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bill4(object sender, RoutedEventArgs e)
        {
            int Time = gtData.getTime(gtData.getFile());
            int price = 30000;
            int tempTime = Time + 10800;

            if (gtData.updateTime(gtData.getFile(), tempTime) && gtData.UpAndInsOdr(gtData.getFile(), "3 Jam", 1, price))
            {
                MessageBox.Show("Add Billing Successfully", "Add Billing Success",
                        MessageBoxButton.OK, MessageBoxImage.Information);

                var mainmenu = new MainMenu();
                NavigationService.Navigate(mainmenu);
            }
            else
            {
                MessageBox.Show("Failed to Add Billing", "Add Billing Failed",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
