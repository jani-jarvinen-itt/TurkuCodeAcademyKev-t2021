using AspNetMvcDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // haetaan tietokannasta aktiiviset asiakasnumerot suuruusjärjestyksessä
            List<int> asiakasNumerot = Tietokanta.HaeAsiakasNumerot();

            // muodostetaan käyttöliittymää varten pilkulla erotettu merkkijono asiakasnumeroista
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }

            // haetaan tietokannasta aktiiviset asiakasnumerot suuruusjärjestyksessä
            List<int> asiakasNumerot = Tietokanta.HaeAsiakasNumerot();

            // muodostetaan käyttöliittymää varten pilkulla erotettu merkkijono asiakasnumeroista
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }
            // haetaan tietokannasta aktiiviset asiakasnumerot suuruusjärjestyksessä
            List<int> asiakasNumerot = Tietokanta.HaeAsiakasNumerot();

            // muodostetaan käyttöliittymää varten pilkulla erotettu merkkijono asiakasnumeroista
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }
            // haetaan tietokannasta aktiiviset asiakasnumerot suuruusjärjestyksessä
            List<int> asiakasNumerot = Tietokanta.HaeAsiakasNumerot();

            // muodostetaan käyttöliittymää varten pilkulla erotettu merkkijono asiakasnumeroista
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }

            return View();
        }


        public IActionResult Index2()
        {
            // vaihe 1
            List<int> asiakasNumerot = Tietokanta.HaeAsiakasNumerot();
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }
            asiakasNumerot = Tietokanta.HaeAsiakasNumerot();
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }

            // vaihe 2
            asiakasNumerot = Tietokanta.HaeAsiakasNumerot();
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }
            asiakasNumerot = Tietokanta.HaeAsiakasNumerot();
            for (int i = 0; i < asiakasNumerot.Count; i++)
            {
                ViewBag.AsiakasNumeroLista += asiakasNumerot[i] + ",";
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private void Kalenteri(int a, int b)
        {
            const int PäiviäViikossa = 7;
            const int PäiviäVuodessa = 365;

            int pvm = a + PäiviäViikossa;
            int vuosi = b + PäiviäVuodessa;

            const float MuunnosKerroin = 22.7f;
            float summa = a + b + MuunnosKerroin;
        }

        private int Summa(int a, int b)
        {
            return a + b;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
