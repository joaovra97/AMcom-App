using System;
using System.Text.RegularExpressions;

namespace AMcom_Models.Models
{
	public class PessoaFisicaModel : ClienteModel
	{
		public string NomeCompleto { get; set; }

		public string CPF { get; set; }

		public string RG { get; set; }

		public DateTime DataNascimento { get; set; }

		public new void Validate()
		{
			if (!Regex.IsMatch(CPF, @"/^\d{3}\.\d{3}\.\d{3}\-\d{2}$/"))
				throw new Exception("Informe um CPF válido!");

			base.Validate();
		}
	}


}
