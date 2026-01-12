using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSwitchesPage : ContentPage
{
	public ControlSwitchesPage()
	{
		BindingContext = new ControlSwitchesViewModel();

        InitializeComponent();
	}
}