using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UutisotsikotYle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Odota, luetaan YLE:n uutisotsikoita...");
            Console.WriteLine();

            await TulostaUutisotsikot();
        }

        static async Task TulostaUutisotsikot()
        {
            UutisotsikkoLukija lukija = new();
            List<string> otsikot = await lukija.LueYlenPääuutisotsikot();
            otsikot.ForEach(o => Console.WriteLine(o));
        }
    }
}
