using System.ComponentModel;

namespace Slooier_voorraad.Classes
{
	public class MagazijnItems
	{
		[Browsable(false)]
		public int Id { get; set; }
		[Browsable(false)]
		public bool Bestellen { get; set; }
		public string Benaming { get; set; }
		public string Nummer { get; set; }
		public string Omschrijving { get; set; }
		public int Voorraad { get; set; }
		[Browsable(false)]
		public double Prijs { get; set; }
	}
}
