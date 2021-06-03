using System;

namespace Merkkijonot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nimi = "Matti Möttönen";
            string osa = nimi.Substring(6, 3);
            Console.WriteLine(osa);

            string osa2 = nimi[6..9];
            Console.WriteLine(osa2);
        }
    }
}
