using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlStepperVMViewModel : ObservableObject
    {
        public string Title => TitleControlStepperVM.Title;

        [ObservableProperty]
        private double stepperValue;

        public ControlStepperVMViewModel()
        {
            StepperValue = 0;
        }

    }
}
