using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionButtonsPage : ContentPage
{
	public CollectionButtonsPage(CollectionButtonsViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
    }
}