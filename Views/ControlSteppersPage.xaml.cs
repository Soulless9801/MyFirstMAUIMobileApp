using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSteppersPage : ContentPage
{
	public ControlSteppersPage()
	{
		BindingContext = new ControlSteppersViewModel();

        InitializeComponent();
	}
}