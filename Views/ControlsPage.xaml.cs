using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		BindingContext = new ControlsViewModel();

        InitializeComponent();
	}
}