using FTP_Server.ViewModels;

namespace FTP_Server.Messages;

public class ChangeViewModelMessage(BaseViewModel viewModel) : IMessage
{
	public BaseViewModel ViewModel { get; } = viewModel;
}