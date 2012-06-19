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
            NavigationService.Navigate(new Uri("/View/PivotVnosPodatkov.xaml", UriKind.Relative));
        }

        private void buttonGraficniPrikaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PivotGraficniPrikaz.xaml", UriKind.Relative));
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

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string najboljsaIzbira="";
            int ocena = 0;
            int najboljasa = 0;

                foreach (var item in App.seznamAlternativ.VrniVseAlternative())
                {
                    ocena = 0;
                    foreach (var parameter in item.SeznamParametrov)
                    {
                        ocena = ocena + parameter.Utez * parameter.Vrednost;
                    }

                    if (najboljasa < ocena)
                    {
                        najboljasa = ocena;
                        najboljsaIzbira = "Najboljša izbira: "+item.Naziv;
                        btnPocisti.Visibility = System.Windows.Visibility.Visible;
                    }
                }

                rezultat.Text = najboljsaIzbira;
            
        }

        private void btnPocisti_Click(object sender, RoutedEventArgs e)
        {
            App.seznamAlternativ.Pocisti();
            App.seznamParametrov.Pocisti();

            rezultat.Text = "";
            btnPocisti.Visibility = System.Windows.Visibility.Collapsed;

        }
    }
}