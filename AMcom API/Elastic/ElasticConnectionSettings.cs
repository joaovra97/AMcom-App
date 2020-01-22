using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMcom_API.Elastic
{
	public class ElasticConnectionSettings
	{
		private string _defaultIndex;

		public string ClusterUrl { get; set; }

		public string DefaultIndex
		{
			get
			{
				return this._defaultIndex;
			}
			set
			{
				this._defaultIndex = value.ToLower();
			}
		}
	}
}
