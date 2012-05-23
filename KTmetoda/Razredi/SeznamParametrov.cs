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
using System.ComponentModel;

namespace KTmetoda.Razredi
{
    public class SeznamParametrov
    {
        //Deklaracija spremenljivke
        private List<Parameter> seznamParametrov = new List<Parameter>();

        //Dodajanje parametrov na seznam
        public void DodajParameter(Parameter p)
        {
            seznamParametrov.Add(p);
        }

        //Vračanje seznama vseh parametrov
        public List<Parameter> VrniVseParametre()
        {
            return seznamParametrov;
        }

        //Odstranjevanje parametra
        public void OdstraniParameter(int id)
        {
            seznamParametrov.RemoveAt(id);
        }

    }
}
