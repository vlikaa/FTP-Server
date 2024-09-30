using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

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
		
		ChangePlaceholderVisibility(passwordBox);
		ChangeShowPassButtonVisibility(passwordBox);
	}
	
	private void ShowPassButton_OnClick(object sender, RoutedEventArgs e)
	{
		if (sender is not Button button)
		{
			return;
		}

		if (button.Content is not PackIcon icon)
		{
			return;
		}

		var template = PasswordBox.Template;
		
		if (template.FindName("PasswordGroupBox", PasswordBox) is not GroupBox passwordGroupBox)
		{
			return;
		}
		
		if (template.FindName("PasswordTextBox", PasswordBox) is not TextBox passwordTextBox)
		{
			return;
		}

		if (passwordGroupBox.Visibility == Visibility.Visible)
		{
			passwordTextBox.Text = PasswordBox.Password;
			
			passwordTextBox.Visibility = Visibility.Visible;
			passwordGroupBox.Visibility = Visibility.Hidden;
			
			icon.Kind = PackIconKind.EyeOff;

			return;
		}
		
		PasswordBox.Password = passwordTextBox.Text;
		passwordTextBox.Visibility = Visibility.Hidden;
		passwordGroupBox.Visibility = Visibility.Visible;
			
		icon.Kind = PackIconKind.Eye;
	}

	private void ChangePlaceholderVisibility(PasswordBox passwordBox)
	{
		var template = passwordBox.Template;

		if (template.FindName("PlaceholderTextBlock", passwordBox) is not TextBlock placeholderTextBlock)
		{
			return;
		}
		
		placeholderTextBlock.Visibility = string.IsNullOrEmpty(passwordBox.Password) ? Visibility.Visible : Visibility.Collapsed;
	}

	private void ChangeShowPassButtonVisibility(PasswordBox passwordBox)
	{
		var template = passwordBox.Template;

		if (template.FindName("ShowPassButton", passwordBox) is not Button showPassButton)
		{
			return;
		}
		
		showPassButton.Visibility = string.IsNullOrEmpty(passwordBox.Password) ? Visibility.Collapsed : Visibility.Visible;
	}
}