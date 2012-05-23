using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace KTmetoda.Razredi
{
    public class Alternativa
    {
        //Deklaracij spremenljivk
        public string Naziv { get; set; }
        public List<Parameter> SeznamParametrov { get; set; }

        //Konstruktorji
        public Alternativa(string naziv, List<Parameter> seznam)
        {
            Naziv = naziv;
            SeznamParametrov = seznam;
        }

        public Alternativa()
        {
        }
    }
}