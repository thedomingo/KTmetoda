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
using Microsoft.Phone.Shell;


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


        private void PivotItem_Loaded(object sender, RoutedEventArgs e)
        {
            listBoxParametri.ItemsSource = App.seznamParametrov.VrniVseParametre();
        }


        //Nalaganje podatkov v listbox
        private void listBoxParametri_Loaded(object sender, RoutedEventArgs e)
        {
            listBoxParametri.ItemsSource = App.seznamParametrov.VrniVseParametre();
        }


        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((Pivot)sender).SelectedIndex)
            {
                case 0:
                    ApplicationBar = ((ApplicationBar)Resources["PivotParameterAppBar"]);
                    break;

                case 1:
                    ApplicationBar = ((ApplicationBar)Resources["PivotAlternativaAppBar"]);
                    break;
            }
        }

        private void ButtonMeni_Click(object sender, EventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void ButtonParameterDodaj_Click(object sender, EventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/DodajParameter.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ButtonParameterUredi_Click(object sender, EventArgs e)
        {
        }

        private void ButtonParameterOdstrani_Click(object sender, EventArgs e)
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

        private void buttonPomoc_Click(object sender, EventArgs e)
        {
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Pomoc.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ButtonAlternativaDodaj_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAlternativaOdstrani_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAlternativaUredi_Click(object sender, EventArgs e)
        {

        }
    }
}