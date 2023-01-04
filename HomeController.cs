using MaasHesabiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaasHesabiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(MaasHesabi maasHesabi)
        {
            var calisma_saati_ = maasHesabi.CalismaSaati;
            var saatlik_ucret_ = maasHesabi.SaatlikUcret;
            var hesap_ = maasHesabi.Hesap;
            if (calisma_saati_ < 40)
            {

                hesap_ = calisma_saati_ * saatlik_ucret_;
                ViewBag.Message = "Maaş Ücretiniz " + hesap_;

            }
            else {
                hesap_ = 2*calisma_saati_ * saatlik_ucret_;
                ViewBag.Message = "Maaş Ücretiniz " + hesap_;

            }

            return View("maasHesabi");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}