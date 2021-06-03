using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDatabaseDemo.Models
{
    public class AsiakkaanPerustiedot
    {
        public string AsiakasId { get; set; }

        public string Nimi { get; set; }

        public string Osoite { get; set; }

        public string Maa { get; set; }

        public int TilaustenLkm { get; set; }
    }
}
