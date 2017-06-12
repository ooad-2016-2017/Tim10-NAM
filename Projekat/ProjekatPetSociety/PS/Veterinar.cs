using System;

namespace ClassLibrary2
{
	public class Veterinar : Uposlenik
	{
		private string fakultet;

		public string Fakultet { get => fakultet; set => fakultet = value; }
		public Veterinar(string i, string p, DateTime dr, string mr, string JMBG, string u, string ps, string em, DateTime datum, string faks)
			: base(i, p, dr, mr, JMBG, u, ps, em, datum)
		{
			fakultet = faks;
		}
	}
}