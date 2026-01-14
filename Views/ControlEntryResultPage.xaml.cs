using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlEntryResultPage : ContentPage
{
	public ControlEntryResultPage()
	{
		BindingContext = new ControlEntryResultViewModel();

        InitializeComponent();
	}
}