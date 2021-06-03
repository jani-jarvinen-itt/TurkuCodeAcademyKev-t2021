using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDatabaseDemo.Controllers
{
    [Route("api/testi")]
    [ApiController]
    public class TestiApiController : ControllerBase
    {
        public int[] Satunnaisluvut()
        {
            const int TaulukonKoko = 10;
            Random random = new();
            int[] luvut = new int[TaulukonKoko];

            for (int indeksi = 0; indeksi < TaulukonKoko; indeksi++)
            {
                int satunnaisluku = random.Next(1, 100);
                luvut[indeksi] = satunnaisluku;
            }

            return luvut;
        }
    }
}
