using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionImagesPage : ContentPage
{
	public CollectionImagesPage()
	{
		InitializeComponent();

		BindingContext = new CollectionImagesViewModel();
	}
}