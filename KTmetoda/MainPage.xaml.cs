using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace KTmetoda
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonVnosPodatkov_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PivotVnosPodatkov.xaml", UriKind.Relative));
        }

        private void buttonGraficniPrikaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PivotGraficniPrikaz.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.RemoveBackEntry() != null)
                {
                    NavigationService.RemoveBackEntry();
                }
            }
        }
    }
}