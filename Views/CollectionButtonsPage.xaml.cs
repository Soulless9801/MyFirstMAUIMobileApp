using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionButtonsPage : ContentPage
{
	public CollectionButtonsPage()
	{
		InitializeComponent();

		BindingContext = new CollectionButtonsViewModel();
    }
}