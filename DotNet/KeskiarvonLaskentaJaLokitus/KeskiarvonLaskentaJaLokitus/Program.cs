using System;

namespace KeskiarvonLaskentaJaLokitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Laske();
        }

        static void Laske()
        {
            const string TiedostoNimi = @"C:\Academy\Turku\DotNet\Numerot.txt";
            
            ILokitus loki = new Lokitus();
            TiedostonLuku luku = new();
            string[] rivit = luku.LueTiedosto(TiedostoNimi, loki);
            int[] luvut = luku.MuunnaNumeroiksi(rivit, loki);

            KeskiarvonLaskenta laskenta = new();
            double keskiarvo = laskenta.LaskeKeskiarvo(luvut, loki);
            Console.WriteLine(keskiarvo);
        }
    }
}
