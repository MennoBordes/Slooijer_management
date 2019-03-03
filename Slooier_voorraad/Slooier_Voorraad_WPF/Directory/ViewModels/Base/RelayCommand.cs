using System;
using System.Windows.Input;

namespace Slooier_Voorraad_WPF
{
	/// <summary>
	/// A basic command that runs an action
	/// </summary>
	public class RelayCommand : ICommand
	{
		#region Private Members

		/// <summary>
		/// The action to run
		/// </summary>
		private Action mAction;

		#endregion

		#region Public  Events
		/// <summary>
		/// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
		/// </summary>
		public event EventHandler CanExecuteChanged = (sender, e) => { };

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RelayCommand(Action action)
		{
			mAction = action;
		}

		#endregion

		#region Command Methods

		/// <summary>
		/// A relay command can allways execute
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		public bool CanExecute(object parameter)
		{
			return true;
		}

		/// <summary>
		/// Executes the commands Action
		/// </summary>
		/// <param name="parameter"></param>
		public void Execute(object parameter)
		{
			mAction();
		}

		#endregion
	}
}
