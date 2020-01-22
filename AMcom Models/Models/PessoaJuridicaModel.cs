using System;
using System.Text.RegularExpressions;

namespace AMcom_Models.Models
{
	public class PessoaJuridicaModel : ClienteModel
	{
		public string RazaoSocial { get; set; }

		public string NomeFantasia { get; set; }

		public string CNPJ { get; set; }

		public string InscricaoEstadual { get; set; }

		public new void Validate()
		{
			if (!Regex.IsMatch(CNPJ, @"/^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$/"))
				throw new Exception("Informe um CNPJ válido!");

			base.Validate();
		}
	}
}
