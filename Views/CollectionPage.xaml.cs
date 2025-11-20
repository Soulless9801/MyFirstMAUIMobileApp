using MAUIFirstMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionPage : ContentPage
{
	public CollectionPage()
	{
		InitializeComponent();

		BindingContext = new CollectionViewModel();
	}
}