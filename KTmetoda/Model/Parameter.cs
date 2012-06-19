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
    public class Parameter
    {
        //Deklaracija spremenljivk
        public string Naziv { get; set; }
        public int Utez { get; set; }
        public int Vrednost { get; set; }

        //Konstruktorji
        public Parameter(string ime, int utez)
        {
            Naziv = ime;
            //Dodana utež
            Utez = utez;
        }


        public Parameter()
        {
            // TODO: Complete member initialization
        }
    }
}
