using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class CollectionIconsPage : ContentPage
{
    public CollectionIconsPage(CollectionMovieUpdateableViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}