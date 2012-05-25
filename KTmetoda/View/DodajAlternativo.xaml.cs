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
using Microsoft.Phone.Shell;
using KTmetoda.Razredi;

namespace KTmetoda.View
{
    public partial class DodajAlternativo : PhoneApplicationPage
    {
        public DodajAlternativo()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationBar = ((ApplicationBar)Resources["VnosAlternativeAppBar"]);
            Alternativa a = new Alternativa(App.seznamParametrov.VrniVseParametre());
            listBoxAlternativaSeznamParametrov.ItemsSource = a.SeznamParametrov;

            

        }

        private void ButtonShraniAlternativa_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPrekliciAlternativa_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PivotVnosPodatkov.xaml", UriKind.Relative));
        }

        private void ButtonPomoc_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Pomoc.xaml", UriKind.Relative));
        }

        private void ParameterVrednost_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }
        
    }
}