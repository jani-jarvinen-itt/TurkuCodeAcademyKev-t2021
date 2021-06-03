using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiarvonLaskentaJaLokitus
{
    public class KeskiarvonLaskenta
    {
        public double LaskeKeskiarvo(int[] luvut, ILokitus loki)
        {
            double summa = luvut.Sum();
            /*
            double summa = 0;
            foreach (int luku in luvut)
            {
                summa += luku;
            }
            */

            double keskiarvo = summa / luvut.Length;

            if (loki is not null)
            {
                loki.Lokita("Keskiarvo laskettu, tulos: " + keskiarvo);
            }

            return keskiarvo;
        }
    }
}
