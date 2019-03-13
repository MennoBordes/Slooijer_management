﻿using System.Windows;
using System.Windows.Input;

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
		/// The smallest width the window can go to
		/// </summary>
		public double WindowMinimumWidth { get; set; } = 400;

		/// <summary>
		/// The smallest height the window can go to
		/// </summary>
		public double WindowMinimumHeight { get; set; } = 400;

		/// <summary>
		/// The size of the resize border around the window
		/// </summary>
		public int ResizeBorder { get; set; } = 6;

		/// <summary>
		/// The size of the resize border around the window, taking into account the outer margin
		/// </summary>
		public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

		/// <summary>
		/// The padding of the inner content of the main window
		/// </summary>
		public Thickness InnerContentPadding { get; set; } = new Thickness(0);

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
		public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

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

		/// <summary>
		/// The height of the title bar / caption of the window
		/// </summary>
		public int TitleHeight { get; set; } = 42;

		/// <summary>
		/// The height of the title bar / caption of the window
		/// </summary>
		public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

		/// <summary>
		/// The current page of the application
		/// </summary>
		public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
		#endregion

		#region Commands

		/// <summary>
		/// The command to minimize the window
		/// </summary>
		public ICommand MinimizeCommand { get; set; }

		/// <summary>
		/// The command to maximize the window
		/// </summary>
		public ICommand MaximizeCommand { get; set; }

		/// <summary>
		/// The command to close the window
		/// </summary>
		public ICommand CloseCommand { get; set; }

		/// <summary>
		/// The command to show the system menu of the window
		/// </summary>
		public ICommand MenuCommand { get; set; }

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
				OnPropertyChanged(nameof(OuterMarginSizeThickness));
				OnPropertyChanged(nameof(WindowRadius));
				OnPropertyChanged(nameof(WindowCornerRadius));
			};

			// Create commands
			MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
			MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
			CloseCommand = new RelayCommand(() => mWindow.Close());
			MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

			// Fix window resize issue
			var resizer = new WindowResizer(mWindow);
		}

		#endregion

		#region Private Helpers

		/// <summary>
		/// Gets the current mouse position on the screen
		/// </summary>
		/// <returns></returns>
		private Point GetMousePosition()
		{
			// Position of the mouse relative to the window
			var position = Mouse.GetPosition(mWindow);

			// Add the window position to its a "ToScreen"
			return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
		}
		#endregion
	}
}
