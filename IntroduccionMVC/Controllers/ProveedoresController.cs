using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
	public class ProveedoresController : Controller
	{
		public string ListaProveedores()
		{
			return "Intel, NVidia, MSI, Kingston, Samsung, Apple, Tupapa";
		}
	}
}
