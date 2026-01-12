using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSwitchVMPage : ContentPage
{
	public ControlSwitchVMPage()
	{
		BindingContext = new ControlSwitchVMViewModel();

		InitializeComponent();
	}
}