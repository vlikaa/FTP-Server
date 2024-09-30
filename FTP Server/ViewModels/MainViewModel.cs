using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using FTP_Server.Messages;
using FTP_Server.Services;

namespace FTP_Server.ViewModels;

[INotifyPropertyChanged]
public partial class MainViewModel : BaseViewModel
{
	public MainViewModel(ViewModelFactory factory)
	{
		ViewModel = factory.Create(typeof(RegisterViewModel));
		
		WeakReferenceMessenger.Default.Register<ChangeViewModelMessage>(this,
			(_, message) =>
			{
				ViewModel = message.ViewModel;
			});
	}
	
	[ObservableProperty] private BaseViewModel _viewModel;
}