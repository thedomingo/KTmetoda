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

namespace KTmetoda.Razredi
{
    public class PData
    {
        public string Title { get; set; }
        public double Value { get; set; }

        public PData(string naziv, double vrednost)
        {
            Title = naziv;
            Value = vrednost;
        }

        public PData()
        {
            // TODO: Complete member initialization
        }
    }
}
