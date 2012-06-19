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
    public class SeznamAlternativ
    {
        //Deklaracija spremenljivke
        private List<Alternativa> seznamAlternativ = new List<Alternativa>();

        //Dodajanje alternative
        public void DodajAlternativo(Alternativa a)
        {
            seznamAlternativ.Add(a);
        }

        //Vračanje seznama vseh alternativ
        public List<Alternativa> VrniVseParametre()
        {
            return seznamAlternativ;
        }

        //Odstranjevanje alternative
        public void OdstraniAlternativo(int id)
        {
            seznamAlternativ.RemoveAt(id);
        }
    }
}
