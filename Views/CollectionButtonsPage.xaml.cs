using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionButtonsPage : ContentPage
{
	public CollectionButtonsPage(CollectionMovieUpdateableViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
    }
}