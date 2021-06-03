using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiarvonLaskentaJaLokitus
{
    public class TiedostonLuku
    {
        public string[] LueTiedosto(string tiedostonimi, ILokitus loki)
        {
            try
            {
                string[] rivit = File.ReadAllLines(tiedostonimi);

                loki?.Lokita("Luettu tiedosto, yhteensä " + rivit.Length + " riviä");
                /*
                if (loki != null)
                {
                    loki.Lokita("Luettu tiedosto, yhteensä " + rivit.Length + " riviä");
                }
                */

                return rivit;
            }
            catch (Exception ex)
            {
                loki.Lokita($"Virhe tiedoston lukemisessa: {ex.Message}");
                
                return Array.Empty<string>();
                // return new string[0];
            }
        }

        public int[] MuunnaNumeroiksi(string[] merkkijonot, ILokitus loki)
        {
            int[] luvut = merkkijonot.Select(int.Parse).ToArray();
            /*
            int[] luvut = new int[merkkijonot.Length];
            int indeksi = 0;
            foreach (string merkkijono in merkkijonot)
            {
                luvut[indeksi] = int.Parse(merkkijono);
                indeksi++;
            }
            */

            if (loki != null)
            {
                loki.Lokita("Muunnettu merkkijonot numeroiksi");
            }

            return luvut;
        }
    }
}
