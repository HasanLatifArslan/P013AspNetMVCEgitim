using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
	public class MVC03DataTransferController : Controller
	{
		public IActionResult Index(string ara)
		{
			// mvc de temel olarak 3 farklı yöntemle ekrana veri gönderebiliriz
			// 1- viewbag: tek kullanımlık ömrü var
			ViewBag.UrunKategorisi = "Bilgisayar";
			// 2- viewdata : tek kullanımlık ömrü var
			ViewData["UrunAdi"] = "Asus Dizüstü Bilgisayar";
			// 3- TempData : iki kullanımlık ömrü var 
			TempData["UrunFiyati"] = 9999;

			ViewBag.GetVerisi = ara;
			return View();
		}
		[HttpPost]
		public IActionResult Index(string text1, string ddlListe, bool cbOnay)
		{

			ViewBag.BirinciYontem = "1. yöntemle (parametrelerden gelen veriler)";
			ViewBag.Mesaj = "Twxtboxdan gelen veri : " + text1;
			ViewBag.MesajListe = "ddlListe den gelen veri : " + ddlListe;
			TempData["Tdata"] = "cbOnaydan Gelen değer : " + cbOnay; 
			return View();
		}
	}
}
