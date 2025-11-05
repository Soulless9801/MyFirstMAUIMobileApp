using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ImagesActivityIndicatorPage : ContentPage
{
	public ImagesActivityIndicatorPage()
	{
		InitializeComponent();

		BindingContext = new ImagesActivityIndicatorViewModel();
	}
}