using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionIconsPage : ContentPage
{
	public CollectionIconsPage()
	{
		InitializeComponent();

		BindingContext = new CollectionIconsViewModel();
    }
}