using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public abstract class Uposlenik: Osoba1
	{
		DateTime datumUposlenja;

		public DateTime DatumUposlenja { get => datumUposlenja; set => datumUposlenja = value; }

		public Uposlenik(string i, string p, DateTime dr, string mr, string JMBG, string u, string ps, string em, DateTime datum)
			: base(i, p, dr, mr, JMBG, u, ps, em)
		{
			datumUposlenja = datum;
		}
	}
}