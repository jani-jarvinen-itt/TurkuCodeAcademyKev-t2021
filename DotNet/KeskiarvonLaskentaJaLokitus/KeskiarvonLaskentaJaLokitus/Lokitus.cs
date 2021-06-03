using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiarvonLaskentaJaLokitus
{
    public class Lokitus : ILokitus
    {
        public string LokiTiedosto { get; } = @"C:\Academy\Turku\DotNet\KeskiarvonLaskentaJaLokitus\Loki.txt";

        public void Lokita(string viesti)
        {
            string aikaleima = DateTime.Now.ToString("d.M.yyyy HH.mm.ss");
            string rivi = $"{aikaleima}: {viesti}.\r\n";
            // string rivi = aikaleima + ": " + viesti + ".\r\n";

            File.AppendAllText(LokiTiedosto, rivi);
        }
    }
}
