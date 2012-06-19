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
using System.Windows.Navigation;

namespace KTmetoda.View
{
    public partial class UrediAlternativo : PhoneApplicationPage
    {
        Alternativa a;
        string id = "";

        public UrediAlternativo()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationContext.QueryString.TryGetValue("alternativa", out id);

            ApplicationBar = ((ApplicationBar)Resources["VnosAlternativeAppBar"]);

            a = App.seznamAlternativ.VrniAlternativo(Convert.ToInt32(id));
            textBoxImeAlternative.Text = a.Naziv;
            listBoxAlternativaSeznamParametrov.ItemsSource = a.SeznamParametrov;
        }

        private void ButtonShraniAlternativa_Click(object sender, EventArgs e)
        {
            a.Naziv = textBoxImeAlternative.Text;

            NavigationService.Navigate(new Uri("/View/PivotVnosPodatkov.xaml?PivotMain.SelectedIndex=1", UriKind.Relative));
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
                if (item.Naziv == tag)
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