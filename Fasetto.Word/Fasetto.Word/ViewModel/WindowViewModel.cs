using System.Windows;

namespace Fasetto.Word.ViewModel
{
	/// <summary>
	/// The View Model for the custom flat window
	/// </summary>
	public class WindowViewModel : BaseViewModel
	{
		#region Private Member

		/// <summary>
		/// The window this view model controls
		/// </summary>
		private Window mWindow;

		/// <summary>
		/// The margin around the window to allow for a drop shadow
		/// </summary>
		private int mOuterMarginSize = 10;

		/// <summary>
		/// The radius of the adges of the window
		/// </summary>
		private int mWindowRadius = 10;
		#endregion

		#region Public Properties

		/// <summary>
		/// The size of the resize border around the window
		/// </summary>
		public int ResizeBorder { get; set; } = 6;

		/// <summary>
		/// The size of the resize border around the window, taking into account the outer margin
		/// </summary>
		public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

		/// <summary>
		/// The margin around the window to allow for a drop shadow
		/// </summary>
		public int OuterMarginSize
		{
			get
			{
				return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
			}
			set
			{
				mOuterMarginSize = value;
			}
		}

		/// <summary>
		/// The margin around the window to allow for a drop shadow
		/// </summary>
		public Thickness OutermarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

		/// <summary>
		/// The radius of the adges of the window
		/// </summary>
		public int WindowRadius
		{
			get
			{
				return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
			}
			set
			{
				mWindowRadius = value;
			}
		}

		/// <summary>
		/// The radius of the adges of the window
		/// </summary>
		public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }


		#endregion

		#region Constructor

		/// <summary>
		/// Default Constructor
		/// </summary>
		public WindowViewModel(Window window)
		{
			mWindow = window;

			// Listen out for the window resizing
			mWindow.StateChanged += (sender, e) =>
			{
				// Fire off events for all propeties that are affected by a resize
				OnPropertyChanged(nameof(ResizeBorder));
				OnPropertyChanged(nameof(ResizeBorderThickness));
				OnPropertyChanged(nameof(OuterMarginSize));
				OnPropertyChanged(nameof(OutermarginSizeThickness));
				OnPropertyChanged(nameof(WindowRadius));
				OnPropertyChanged(nameof(WindowCornerRadius));
			};
		}

		#endregion

	}
}
