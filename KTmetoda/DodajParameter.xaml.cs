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
            textBoxImeParametra.Focus();
            string s = textBoxImeParametra.Text;
            textBoxImeParametra.Text = "";

            App.seznamParametrov.DodajParameter(new Parameter(s));

            NavigationService.Navigate(new Uri("/PivotVnosPodatkov.xaml", UriKind.Relative));
        }        
    }
}