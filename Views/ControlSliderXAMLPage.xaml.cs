using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSliderXAMLPage : ContentPage
{
	public ControlSliderXAMLPage()
	{
		InitializeComponent();

		BindingContext = new ControlSliderXAMLViewModel();

		UpdateVisuals(MySlider.Value);

        SetPlatformPadding();
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e) => UpdateVisuals(e.NewValue);

    private void UpdateVisuals(double value)
	{
        MyBox.Opacity = value;

        ValueLabel.Text = $"Slider Value: {value:F2}";

        InfoLabel.Opacity = value;
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