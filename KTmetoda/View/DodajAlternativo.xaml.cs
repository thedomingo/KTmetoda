﻿using System;
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
        Alternativa a;

        public DodajAlternativo()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationBar = ((ApplicationBar)Resources["VnosAlternativeAppBar"]);
            a = new Alternativa(App.seznamParametrov.VrniVseParametre());
            listBoxAlternativaSeznamParametrov.ItemsSource = a.SeznamParametrov;

        }

        private void ButtonShraniAlternativa_Click(object sender, EventArgs e)
        {
            if (textBoxImeAlternative.Text!="")
            {
                a.Naziv = textBoxImeAlternative.Text;
                App.seznamAlternativ.DodajAlternativo(a);

                NavigationService.Navigate(new Uri("/View/PivotVnosPodatkov.xaml?PivotMain.SelectedIndex=1", UriKind.Relative));  
            }

            else
            {
                MessageBox.Show("Ime alternative ni vpisano!");
            }
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
            var sliderTrenutni = (Slider)sender;

            sliderTrenutni.Value = Math.Round(e.NewValue);

            string tag = sliderTrenutni.Tag.ToString();

            NastaviVrednostParameter(tag, sliderTrenutni.Value);

        }

        private void NastaviVrednostParameter(string tag, double p)
        {
            foreach (var item in a.SeznamParametrov)
            {
                if (item.Naziv==tag)
                {
                    item.Vrednost = (int)p;
                }
            }
        }

        private void buttonOProgramu_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/OProgramu.xaml", UriKind.Relative));
        }

        
        
    }
}