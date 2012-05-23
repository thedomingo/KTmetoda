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
using KTmetoda.Razredi;

namespace KTmetoda
{
    public partial class PivotVnosPodatkov : PhoneApplicationPage
    {
        //Deklaracija spremenljivk
        Parameter p = new Parameter();
        Alternativa a = new Alternativa();

        public PivotVnosPodatkov()
        {
            InitializeComponent();
        }

        //???????????
        void PivotVnosPodatkov_Loaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //Gumb za dodajanje novega parametra
        private void buttonNovParameter_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DodajParameter.xaml", UriKind.Relative));
        }

        //Gumb pomoč
        private void buttonPomoc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pomoc.xaml", UriKind.Relative));
        }

        private void PivotItem_Loaded(object sender, RoutedEventArgs e)
        {
            listBoxParametri.ItemsSource = App.seznamParametrov.VrniVseParametre();
        }

        //Gumb za odstranjevanje parametra
        private void buttonOdstraniParameter_Click(object sender, RoutedEventArgs e)
        {
            //Pridobitev id parametra
            int id = listBoxParametri.SelectedIndex;

            //Objava napake če id ni izbran
            if (id != -1)
            {
                App.seznamParametrov.OdstraniParameter(id);
                NavigationService.Navigate(new Uri(NavigationService.Source + "?Refresh=true", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Izbran ni noben parameter!");
            }


        }
        //????????
        private void OsveziPodatke()
        {
            listBoxParametri.ItemsSource = App.seznamParametrov.VrniVseParametre();
        }
        //???????
        private void listBoxParametri_Loaded(object sender, RoutedEventArgs e)
        {
            listBoxParametri.ItemsSource = App.seznamParametrov.VrniVseParametre();
        }

        //Gumb za dodajanje nove alternative
        private void buttonNovaAlternativa_Click(object sender, RoutedEventArgs e)
        {

        }

        //Gumb za odstranjevanje alternative
        private void buttonOdstraniAlternativo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}