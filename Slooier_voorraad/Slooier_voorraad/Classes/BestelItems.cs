using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slooier_voorraad.Classes
{
	class BestelItems
	{
		public string Benaming { get; set; }
		public string Nummer { get; set; }
		public string Omschrijving { get; set; }
		public int Voorraad { get; set; }
		public int Bestel_aantal { get; set; }
		public string Soort { get; set; }
		public float Prijs { get; set; }
	}

	// Custom comparer
	class BestelItemsComparer : IEqualityComparer<BestelItems>
	{
		public bool Equals(BestelItems x, BestelItems y)
		{
			// check if any of the compared objects is null
			if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null)) return false;
			
			// objects are equal
			if (Object.ReferenceEquals(x, y)) return true;
			
			// check whether properties are equal
			return x.Omschrijving == y.Omschrijving && x.Nummer == y.Nummer;
		}

		public int GetHashCode(BestelItems obj)
		{
			// check whether object is null
			if (Object.ReferenceEquals(obj, null)) return 0;

			// Get hash code for the omschrijving field if not null
			int hashItemOmschrijving = obj.Omschrijving == null ? 0 : obj.Omschrijving.GetHashCode();

			// Get hash code for the nummer field if not null
			int hashItemNummer = obj.Nummer == null ? 0 : obj.Nummer.GetHashCode();

			// Calculate the hash code for the item
			return hashItemOmschrijving ^ hashItemNummer;
		}
	}
}
