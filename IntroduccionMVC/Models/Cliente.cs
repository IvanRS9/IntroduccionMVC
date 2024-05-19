namespace IntroduccionMVC.Models
{
	public class Cliente
	{
		public int Id {  get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public DateTime FechaAlta { get; set; }
		public string Correo { get; set; }
	}
}
