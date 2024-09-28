using System.Windows;
using System.Windows.Controls;

namespace FTP_Server.Controls;

public partial class CustomPasswordBox
{
	public CustomPasswordBox()
	{
		InitializeComponent();

		DataContext = this;
	}
	
	public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.Register(
		nameof(Placeholder), typeof(string), typeof(CustomPasswordBox), new PropertyMetadata(default(string)));
	
	public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
		nameof(Title), typeof(string), typeof(CustomPasswordBox), new PropertyMetadata(default(string)));
	
	public string Placeholder
	{
		get => (string)GetValue(PlaceholderProperty);
		set => SetValue(PlaceholderProperty, value);
	}
	
	public string Title
	{
		get => (string)GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}
	
	private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
	{
		if (sender is not PasswordBox passwordBox)
		{
			return;
		}

		var template = passwordBox.Template;

		if (template.FindName("PlaceholderTextBlock", passwordBox) is not TextBlock placeholderTextBlock)
		{
			return;
		}
		
		placeholderTextBlock.Visibility = string.IsNullOrEmpty(passwordBox.Password) ? Visibility.Visible : Visibility.Collapsed;
	}
}