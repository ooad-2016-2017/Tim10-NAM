using System;

namespace ClassLibrary2
{
	public class Pregled
	{
		private DateTime datum;
		private Veterinar veterinar;
		private Ljubimac ljubimac;
		private string opis;

		public Pregled(DateTime d, Veterinar v, Ljubimac lj, String o)
		{
			this.datum = d;
			this.veterinar = v;
			this.ljubimac = lj;
			this.opis = o;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string Opis { get => opis; set => opis = value; }
		internal Veterinar Veterinar { get => veterinar; set => veterinar = value; }
		internal Ljubimac Ljubimac { get => ljubimac; set => ljubimac = value; }
	}
}




