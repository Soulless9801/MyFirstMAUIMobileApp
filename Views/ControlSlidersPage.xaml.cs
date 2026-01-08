using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSlidersPage : ContentPage
{
    public ControlSlidersPage()
    {
        BindingContext = new ControlSlidersViewModel();

        InitializeComponent();
    }
}