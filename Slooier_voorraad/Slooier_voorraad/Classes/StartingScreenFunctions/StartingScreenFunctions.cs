using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slooier_voorraad.Classes.StartingScreenFunctions
{
	static class StartingScreenFunctions
	{
		public static double GetDouble(string value, double defaultValue)
		{
			if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out double result) &&
				!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out result) &&
				!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				result = defaultValue;
			}
			return result;
		}
	}
}
