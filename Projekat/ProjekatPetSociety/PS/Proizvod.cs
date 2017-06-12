using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public class Proizvod
	{
		private string ID;
		private string naziv;
		private string stanje;
		private string cijena;

		public Proizvod(string id, string n, string s, string c)
		{
			ID = id;
			naziv = n;
			stanje = s;
			cijena = c;
		}

		public string ID1 { get => ID; set => ID = value; }
		public string Naziv { get => naziv; set => naziv = value; }
		public string Stanje { get => stanje; set => stanje = value; }
		public string Cijena { get => cijena; set => cijena = value; }
	}
}
