namespace Slooier_voorraad.Classes.UserInput
{
	public class UserInputChecker
	{
		/// <summary>
		/// Returns a status 
		/// </summary>
		public enum InputResult
		{
			/// <summary>
			/// The action is valid
			/// </summary>
			Valid,

			/// <summary>
			/// The action didn't contain text
			/// </summary>
			NoText,

			/// <summary>
			/// The action contain(s) a invalid character
			/// </summary>
			InValidChar
		}

		/// <summary>
		/// Takes a string and returns a <see cref="InputResult"/>.
		/// </summary>
		/// <param name="TextToCheck">The text to check.</param>
		/// <param name="AllowedCharacters">The allowed characters to check against.</param>
		/// <returns></returns>
		public static InputResult UserInput(string TextToCheck, string AllowedCharacters)
		{
			if (TextToCheck.Length <= 0)
				return InputResult.NoText;

			if (!CommonFunctions.CommonFunctions.IsStringValid(TextToCheck, AllowedCharacters))
				return InputResult.InValidChar;

			return InputResult.Valid;
		}

		/// <summary>
		/// Takes a string and returns a <see cref="InputResult"/>.
		/// </summary>
		/// <param name="TextToCheck">The text to check.</param>
		/// <returns></returns>
		public static InputResult UserOmschrijvingInput(string TextToCheck)
		{
			// Defining the allowed characters
			string AllowedCharacters;

			// \p{L} allows all normal text
			// \w\ allows all numbers
			// .,/-+ allows those characters to be used
			AllowedCharacters = @"^[\p{L}\w\.,+/ -]+$";

			return UserInput(TextToCheck, AllowedCharacters);
		}

		/// <summary>
		/// Takes a string and returns a <see cref="InputResult"/>.
		/// </summary>
		/// <param name="TextToCheck">The text to check.</param>
		/// <returns></returns>
		public static InputResult UserNummerInput(string TextToCheck)
		{
			// Defining the allowed characters
			string AllowedCharacters;

			// \p{L} allows all normal text
			// \w\ allows all numbers
			// .,/-+ allows those characters to be used
			AllowedCharacters = @"^[A-Za-z0-9]+$";

			return UserInput(TextToCheck, AllowedCharacters);
		}

		/// <summary>
		/// Takes a string and returns a <see cref="InputResult"/>.
		/// </summary>
		/// <param name="TextToCheck">The text to check.</param>
		/// <returns></returns>
		public static InputResult UserVoorraadInput(string TextToCheck)
		{
			// Defining the allowed characters
			string AllowedCharacters;

			// \p{L} allows all normal text
			// \w\ allows all numbers
			// .,/-+ allows those characters to be used
			AllowedCharacters = @"^[0-9]+$";

			return UserInput(TextToCheck, AllowedCharacters);
		}
	}
}
