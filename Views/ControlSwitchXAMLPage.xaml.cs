using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlSwitchXAMLPage : ContentPage
{
	public ControlSwitchXAMLPage()
	{
		BindingContext = new ControlSwitchXAMLViewModel();

        InitializeComponent();
	}

	private void OnSwitchToggled(object sender, ToggledEventArgs e)
	{
		label.TextColor = e.Value
			? Color.FromRgb(0, 0, 255)
			: Color.FromRgb(255, 0, 0);
    }	
}