using AMcom_Models.Models.Enums;

namespace AMcom_Models.Models
{
	public class ContatoModel
	{
		public string Telefone { get; set; }

		public string Email { get; set; }

		public TipoContatoEnum TipoContato { get; set; }

	}
}
