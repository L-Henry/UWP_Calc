using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Calc
{
    public static class BerekenClass
    {
        public static double Bereken(double get1, double get2, string bewerking)
        {
            switch (bewerking)
            {
                case "+":
                    return get1 + get2;
                case "-":
                    return get1 - get2;
                case "X":
                    return get1 * get2;
                case "/":
                    return get1 / get2;
                default:
                    return 0;
            }
        }
    }
}
