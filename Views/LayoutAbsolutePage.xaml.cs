using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class LayoutAbsolutePage : ContentPage
{
	public LayoutAbsolutePage()
	{
		InitializeComponent();

		BindingContext = new LayoutAbsoluteViewModel();
	}
}