using System;
using LaskentaKirjasto;

namespace UseitaProjekteja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa laina-laskuriin!");

            Laske();
        }

        public static void Laske()
        {
            Console.WriteLine("Syötä lainan määrä:");
            double määrä = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä laina-aika kuukausina:");
            int aikaKk = int.Parse(Console.ReadLine());

            LainanLaskenta laskenta = new();
            double kkErä = laskenta.LaskeKuukausiErä(määrä, aikaKk);
            Console.WriteLine("Lainan kk-erä on: " + kkErä);
        }

        public static int Summa(int a, int b)
        {
            return a + b;
        }

        public static int Summa2(int a, int b) => a + b;
    }
}
