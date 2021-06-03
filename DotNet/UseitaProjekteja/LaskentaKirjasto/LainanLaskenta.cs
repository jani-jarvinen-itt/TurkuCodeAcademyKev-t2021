using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskentaKirjasto
{
    public class LainanLaskenta
    {
        public double LaskeKuukausiErä(double lainanMäärä, int takaisinMaksuAika)
        {
            const double Korko = 1.05;
            double kkErä = lainanMäärä / takaisinMaksuAika * Korko;
            return kkErä;
        }
    }
}
