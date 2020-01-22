using System;
using System.Collections.Generic;

namespace AMcom_Models.Models
{
	public class ClienteModel
	{
		public ClienteModel()
		{
			Contatos = new List<ContatoModel>();
			Enderecos = new List<EnderecoModel>();
			ValorLimiteCredito = 100;
		}

		public decimal ValorLimiteCredito { get; set; }

		public List<ContatoModel> Contatos { get; set; }

		public List<EnderecoModel> Enderecos { get; set; }

		public void Validate()
		{
			if (Enderecos.Count < 1)
				throw new Exception("Selecione ao menos 1 Endereço!");

			if (Enderecos.Count > 3)
				throw new Exception("Selecione no máximo 3 Endereço!");

			if (ValorLimiteCredito < 0)
				throw new Exception("Valor de Limite de Crédito deve ser maior que 0R$!");
		}
	}
}
