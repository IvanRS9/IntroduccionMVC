using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
	public class InicioController : Controller
	{
		public readonly ILogger<InicioController> _logger;
		public string Index()
		{
			return "Hey yoooo mother fucker nigga ";
		}

		public IActionResult Buscar(string nombre)
		{
			Console.WriteLine($"El nombre es: {nombre}");
			return Content("El nombre a buscar es: " + nombre);
		}

		public ActionResult Redirecciona()
		{
			return RedirectToAction();
		}
	}
}
