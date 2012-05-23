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
    public partial class DodajParameter : PhoneApplicationPage
    {
        Parameter p;
        public DodajParameter()
        {
            InitializeComponent();
        }

        private void buttonDodajParameter_Click(object sender, RoutedEventArgs e)
        {
            //Dodajanje imena parametra
            textBoxImeParametra.Focus();
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
            else
            {
                App.seznamParametrov.DodajParameter(new Parameter(s, utez));

                //Vrnitev nazaj na stran z vnosom podatkov
                NavigationService.Navigate(new Uri("/PivotVnosPodatkov.xaml", UriKind.Relative));
            }
        }

        private void ParameterVrednostSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Zaokroževanje številk pri sliderju
          ParameterVrednostSlider.Value = Math.Round(e.NewValue);
        }
    }
}