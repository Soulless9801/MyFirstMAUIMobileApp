using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlStepperXAMLPage : ContentPage
{
	public ControlStepperXAMLPage()
	{
		BindingContext = new ControlStepperXAMLViewModel();

		InitializeComponent();
	}

	private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
	{
		UpdateUI(e.NewValue % 360);
	}

	private void UpdateUI(double value)
	{
		RotatingLabel.Rotation = value;
		DisplayLabel.Text = $"The Stepper value is {value:F0}";
	}
}