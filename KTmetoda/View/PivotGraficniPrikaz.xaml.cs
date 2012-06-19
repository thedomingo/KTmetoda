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
using System.Collections.ObjectModel;
using KTmetoda.Razredi;

namespace KTmetoda
{
    public partial class PivotGraficniPrikaz : PhoneApplicationPage
    {
        public PivotGraficniPrikaz()
        {
            InitializeComponent();
        }

        private void PivotItemUtezi_Loaded(object sender, RoutedEventArgs e)
        {
            GraficniPrikazUtezi();
        }

        private void GraficniPrikazUtezi()
        {
            ObservableCollection<PData> podatki = new ObservableCollection<PData>();

            foreach (var item in App.seznamParametrov.VrniVseParametre())
            {
                podatki.Add(new PData(item.Naziv, item.Utez));
            }

            pie1.DataSource= podatki;
        }

        private void GraficniPrikazOcene()
        {
            ObservableCollection<PData> podatkiOcena = new ObservableCollection<PData>();

            foreach (var item in App.seznamAlternativ.VrniVseAlternative())
            {
                PData podatek = new PData();
                podatek.Title = item.Naziv;
                int ocena = 0;

                foreach (var parameter in item.SeznamParametrov)
                {
                    ocena = ocena + parameter.Utez * parameter.Vrednost;
                }

                podatek.Value = ocena;

                podatkiOcena.Add(podatek);
            }

            chart1.DataSource = podatkiOcena;
        }

        private void PivotItemOcena_Loaded(object sender, RoutedEventArgs e)
        {
            GraficniPrikazOcene();
        }
    }
}