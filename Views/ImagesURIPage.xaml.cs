using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ImagesURIPage : ContentPage
{
	public ImagesURIPage()
	{
		InitializeComponent();

		BindingContext = new ImagesURIViewModel();
	}
}