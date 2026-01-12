using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlStepperVMPage : ContentPage
{
	public ControlStepperVMPage()
	{
		BindingContext = new ControlStepperVMViewModel();

		InitializeComponent();
	}
}