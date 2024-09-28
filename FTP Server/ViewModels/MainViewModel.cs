using CommunityToolkit.Mvvm.ComponentModel;
using FTP_Server.Services;

namespace FTP_Server.ViewModels;

[INotifyPropertyChanged]
public partial class MainViewModel : BaseViewModel
{
	public MainViewModel(ViewModelFactory factory)
	{
		ViewModel = factory.Create(typeof(RegisterViewModel));
	}
	
	[ObservableProperty] private BaseViewModel _viewModel;
}