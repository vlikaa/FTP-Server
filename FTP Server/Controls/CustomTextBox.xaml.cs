using System.Windows;

namespace FTP_Server.Controls;

public partial class CustomTextBox
{
	public CustomTextBox()
	{
		InitializeComponent();
	}

	public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.Register(
		nameof(Placeholder), typeof(string), typeof(CustomTextBox), new PropertyMetadata(default(string)));

	public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
		nameof(Title), typeof(string), typeof(CustomTextBox), new PropertyMetadata(default(string)));
		
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
}