using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
	public class CV : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Academy()
		{
			return View();
		}

		public IActionResult Experience()
		{
			return View();
		}
	}
}
