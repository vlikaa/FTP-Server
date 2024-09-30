using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using FTP_Server.Messages;
using FTP_Server.Services;

namespace FTP_Server.ViewModels;

[INotifyPropertyChanged]
public partial class RegisterViewModel(ViewModelFactory factory) : BaseViewModel
{
	[RelayCommand]
	private void OpenLoginView()
	{
		WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(factory.Create(typeof(LoginViewModel))));
	}
}