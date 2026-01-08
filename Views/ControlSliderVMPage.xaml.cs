using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSliderVMPage : ContentPage
{
    public ControlSliderVMPage()
    {
        BindingContext = new ControlSliderVMViewModel();

        InitializeComponent();

        SetPlatformPadding();
    }

    private void SetPlatformPadding()
    {
        if (DeviceInfo.Platform == DevicePlatform.iOS
         || DeviceInfo.Platform == DevicePlatform.Android)
        {
            Padding = new Thickness(25);
        }
        else
        {
            Padding = Thickness.Zero;
        }
    }
}