using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ClassLibrary2
{
	public class Ljubimac
	{
		private string naziv;
		private string IDVlasnika;
		private string vrsta;
		private string rasa;
		private int starost;
		private List<Pregled> lista_pregleda;
		private Image slika;

		public string Naziv { get => naziv; set => naziv = value; }
		public string IDVlasnika1 { get => IDVlasnika; set => IDVlasnika = value; }
		public string Vrsta { get => vrsta; set => vrsta = value; }
		public string Rasa { get => rasa; set => rasa = value; }
		public int Starost { get => starost; set => starost = value; }
		public Image Slika { get => slika; set => slika = value; }

		public Ljubimac(string n, string iv, string v, string r, int st, List<Pregled> lp, Image im)
		{
			naziv = n;
			IDVlasnika = iv;
			vrsta = v;
			rasa = r;
			starost = st;
			lista_pregleda = new List<Pregled>();
			slika = im;
		}

	}
}