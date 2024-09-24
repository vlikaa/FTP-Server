using System.Windows;
using FTP_Server.Views;
using FTP_Server.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace FTP_Server;

public partial class App
{
	private readonly ServiceCollection _serviceCollection = [];
	private static ServiceProvider? _serviceProvider;
	
	public static ServiceProvider ServiceProvider => _serviceProvider!;

	protected override void OnStartup(StartupEventArgs e)
	{
		base.OnStartup(e);
		
		_serviceCollection.AddSingleton<MainView>();
		_serviceCollection.AddSingleton<MainViewModel>();

		_serviceProvider = _serviceCollection.BuildServiceProvider();
		
		var view = _serviceProvider.GetRequiredService<MainView>();
		
		view.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
		
		view.ShowDialog();
	}
}