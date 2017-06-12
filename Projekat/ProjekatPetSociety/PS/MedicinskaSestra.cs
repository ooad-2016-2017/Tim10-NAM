using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public class MedicinskaSestra: Uposlenik
	{
		private string strucnaSprema;

		public MedicinskaSestra(string i, string p, DateTime dr, string mr, string JMBG, string u, string ps, string em, DateTime datum, string spp)
			: base(i, p, dr, mr, JMBG, u, ps, em, datum)
		{
			strucnaSprema = spp;
		}

		public string StrucnaSprema { get => strucnaSprema; set => strucnaSprema = value; }
	}
}




