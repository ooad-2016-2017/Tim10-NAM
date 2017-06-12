using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public abstract class Osoba1
	{
		private string ime;
		private string prezime;
		private DateTime datum_rodjenja;
		private string mjesto_rodjenja;
		private string JMBG;
		private string username;
		private string password;
		private string email;
		public string Ime { get => ime; set => ime = value; }
		public string Prezime { get => prezime; set => prezime = value; }
		public DateTime Datum_rodjenja { get => datum_rodjenja; set => datum_rodjenja = value; }
		public string Mjesto_rodjenja { get => mjesto_rodjenja; set => mjesto_rodjenja = value; }
		public string JMBG1 { get => JMBG; set => JMBG = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Email { get => email; set => email = value; }

		public Osoba1(string i, string p, DateTime dr, string mr, string JMBG, string u, string ps, string em)
		{
			ime = i;
			prezime = p;
			datum_rodjenja = dr;
			mjesto_rodjenja = mr;
			this.JMBG = JMBG;
			username = u;
			password = p;
			email = em;
		}
	}
}