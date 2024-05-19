using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduccionMVC.Controllers
{
	public class ClientesController : Controller
	{
		public static List<Cliente> ListaCliente = new List<Cliente>
		{
			new Cliente
			{
				Id = 1,
				Nombre = "Ivan",
				Apellido = "Ramirez",
				FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
				Correo = "rziv@gmail.com"
			},
			new Cliente
			{
				Id = 2,
				Nombre = "Leah",
				Apellido = "Ramirez",
				FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
				Correo = "rzlh@gmail.com"
			}
		};

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Pedidos()
		{
			return View();
		}

		public IActionResult ListadoClientes()
		{
			return View(ListaCliente);
		}
	}
}
