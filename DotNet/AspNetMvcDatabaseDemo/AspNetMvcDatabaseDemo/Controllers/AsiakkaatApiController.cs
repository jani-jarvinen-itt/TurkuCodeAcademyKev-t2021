using AspNetMvcDatabaseDemo.Database;
using AspNetMvcDatabaseDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDatabaseDemo.Controllers
{
    [Route("api/asiakkaat")]
    [ApiController]
    public class AsiakkaatApiController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Customer> KaikkiAsiakkaat()
        {
            /*NorthwindContext context = new();
            try
            {
                List<Customer> asiakkaat = context.Customers.ToList();
                return asiakkaat;
            }
            finally
            {
                context.Dispose();
            }*/

            // lyhyempi muoto
            using NorthwindContext context = new();
            List<Customer> asiakkaat = context.Customers.ToList();
            return asiakkaat;
        }

        [HttpGet]
        [Route("{asiakasId:length(5)}")]
        public AsiakkaanPerustiedot AsiakkaanPerustiedot(string asiakasId)
        {
            NorthwindContext context = new();

            //context.Dispose();

            Customer asiakas = context.Customers.Find(asiakasId);
            if (asiakas is not null)
            {
                // LINQ-kysely
                int tilausLkm = context.Orders.Where(
                    o => o.CustomerId == asiakasId).Count();

                // tietojen kopiointi
                AsiakkaanPerustiedot perustiedot = new()
                {
                    AsiakasId = asiakas.CustomerId,
                    Nimi = asiakas.CompanyName,
                    Osoite = asiakas.Address,
                    Maa = asiakas.Country,
                    TilaustenLkm = tilausLkm
                };

                return perustiedot;
            }

            return null;
        }
    }
}
