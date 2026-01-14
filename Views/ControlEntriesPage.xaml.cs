using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlEntriesPage : ContentPage
{
	public ControlEntriesPage()
	{
		BindingContext = new ControlEntriesViewModel();

		InitializeComponent();
	}
}