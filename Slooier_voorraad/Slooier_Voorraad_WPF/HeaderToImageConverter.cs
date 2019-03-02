﻿using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Slooier_Voorraad_WPF
{
	/// <summary>
	/// Convert a full path to a specific image type of a drive, folder or file
	/// </summary>
	[ValueConversion(typeof(string), typeof(BitmapImage))]
	public class HeaderToImageConverter : IValueConverter
	{
		public static HeaderToImageConverter Instance = new HeaderToImageConverter();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// Get the full path
			var path = (string)value;

			// If the path is null, ignore
			if (path == null)
				return null;

			// Get the name of the file/folder
			var name = Window1.GetFileFolderName(path);

			// By default, we presume an image
			var image = "Images/File.png";

			// If the name is blank, we presume it's a drive as we cannot have a blank file or folder name
			if (string.IsNullOrEmpty(name))
				image = "Images/Drive.png";
			else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
				image = "Images/Folder.png";


			return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
