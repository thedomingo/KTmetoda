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
    public partial class DodajParameter : PhoneApplicationPage
    {
        Parameter p;
        public DodajParameter()
        {
            InitializeComponent();
        }

        private void ParameterVrednostSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Zaokroževanje številk pri sliderju
          ParameterVrednostSlider.Value = Math.Round(e.NewValue);
        }

        private void ButtonShraniParameter_Click(object sender, EventArgs e)
        {
            //Dodajanje imena parametra

            string s = textBoxImeParametra.Text;

            //Dodajanje uteži parametru, ter v razredu parameter konstruktorju dodana utež
            VrednostUtezi.Text = ParameterVrednostSlider.Value.ToString();
            int utez = Convert.ToInt32(ParameterVrednostSlider.Value);

            //Dodajanje parametra
            if (s == "")
            {
                MessageBox.Show("Ime parametra ni vpisano!");
                NavigationService.Navigate(new Uri(NavigationService.Source + "?Refresh=true", UriKind.Relative));
            }
            else if(utez==0)
            {
                MessageBox.Show("Utež ni nastavljena!");
                NavigationService.Navigate(new Uri(NavigationService.Source + "?Refresh=true", UriKind.Relative));

                
            }
            else
            {
                App.seznamParametrov.DodajParameter(new Parameter(s, utez));

                //Vrnitev nazaj na stran z vnosom podatkov
                NavigationService.Navigate(new Uri("/View/PivotVnosPodatkov.xaml", UriKind.Relative));
            }
        }

        private void ButtonPrekliciParameter_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PivotVnosPodatkov.xaml", UriKind.Relative));
        }

        private void ButtonPomoc_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Pomoc.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
            ApplicationBar = ((ApplicationBar)Resources["VnosParameteraAppBar"]);
            textBoxImeParametra.Focus();
        }
    }
}