using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionEditPage : ContentPage
{
	public CollectionEditPage()
	{
		InitializeComponent();

		BindingContext = new CollectionEditViewModel();
    }

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		if (query.TryGetValue("movieName", out var raw) && BindingContext is CollectionEditViewModel vm)
		{
			vm.MovieName = Uri.UnescapeDataString(raw as string ?? string.Empty);
        }
    }	
}