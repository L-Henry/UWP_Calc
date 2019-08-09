using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Calc
{
    public class Calculator
    {
        public string DisplayValue { get; set; }
        public string Display2Value { get; set; }

        public List<HistoryViewModel> History { get; set; }

        public bool GetalIngevuld { get; set; }
        public string Bewerking { get; set; }
        public string Getal1 { get; set; }
        public string Getal2 { get; set; }
        public bool InvertAfgehandeld { get; set; } = true;

    }
}
