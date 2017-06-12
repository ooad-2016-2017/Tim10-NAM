using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public class Klijent : Osoba1
	{
		private string ID;
		private string adresa;
		private string kontakt_tel;
		List<Ljubimac> lista_ljubimaca;
		public string ID1 { get => ID; set => ID = value; }
		public string Adresa { get => adresa; set => adresa = value; }
		public string Kontakt_tel { get => kontakt_tel; set => kontakt_tel = value; }

		public Klijent(string i, string p, DateTime dr, string mr, string JMBG, string u, string ps, string em, string id, string ad, string tel)
		 : base (i, p, dr, mr, JMBG, u, ps, em)
		{
			ID = id;
			adresa = ad;
			kontakt_tel = tel;
			lista_ljubimaca = new List<Ljubimac>();
		}
	}
}