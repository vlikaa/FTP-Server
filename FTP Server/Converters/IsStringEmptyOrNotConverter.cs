using System.Globalization;
using System.Windows.Data;

namespace FTP_Server.Converters;

public class IsStringEmptyOrNotConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		return !string.IsNullOrEmpty(value as string);
	}

	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		return new object();
	}
}