using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JsonTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JSON-testisovellus v1.0");

            // vaihe 1: luetaan asiakkaiden tiedot
            List<Asiakas> asiakkaat = new();
            Asiakas asiakas;
            do
            {
                asiakas = LueAsiakastiedot();
                if (asiakas.Nimi != "")
                {
                    asiakkaat.Add(asiakas);
                }
            }
            while (asiakas.Nimi != "");

            // vaihe 2: json-muunnos ja tallennus tiedostoon
            string json = JsonSerializer.Serialize(asiakkaat);
            // Console.WriteLine(json);
            File.WriteAllText("Asiakkaat.json", json);
        }

        static Asiakas LueAsiakastiedot()
        {
            Console.WriteLine("Anna asiakkaan id-numero:");
            string id = Console.ReadLine();
            Console.WriteLine("Anna asiakkaan nimi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("Anna asiakkaan puhelinnumero:");
            string puhelin = Console.ReadLine();

            Asiakas asiakas = new()
            {
                AsiakasId = int.Parse(id),
                Nimi = nimi,
                Puhelinnumero = puhelin
            };

            return asiakas;
        }
    }

    public class Asiakas
    {
        public int AsiakasId { get; set; }

        public string Nimi { get; set; }

        public string Puhelinnumero { get; set; }
    }
}
