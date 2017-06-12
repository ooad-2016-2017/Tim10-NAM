using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public class Narudzba
	{
		private List<Proizvod> listaProizvoda;
		private double ukupnaCijena;
		private DateTime datum;
		private string napomena;
		private string IDKlijenta;
		private bool nacinPlacanja;
		//true - kes false - kartica

		public Narudzba(double uc, DateTime d, string n, string id, bool np)
		{
			listaProizvoda = new List<Proizvod>();
			ukupnaCijena = uc;
			datum = d;
			napomena = n;
			IDKlijenta = id;
			nacinPlacanja = np;
		}

		public List<Proizvod> ListaProizvoda { get => listaProizvoda; set => listaProizvoda = value; }
		public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }
		public DateTime Datum { get => datum; set => datum = value; }
		public string Napomena { get => napomena; set => napomena = value; }
		public string IDKlijenta1 { get => IDKlijenta; set => IDKlijenta = value; }
		public bool NacinPlacanja { get => nacinPlacanja; set => nacinPlacanja = value; }

		
	}
}