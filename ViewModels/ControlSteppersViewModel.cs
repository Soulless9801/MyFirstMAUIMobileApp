using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlSteppersViewModel : ObservableObject
    {
        public string Title => TitleControlSteppers.Title;

        public string StepperVMButtonText => TitleControlSteppers.StepperVMButtonText;

        public string StepperXAMLButtonText => TitleControlSteppers.StepperXAMLButtonText;

        [RelayCommand]
        private async Task StepperVMButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlStepperVMPage));
        }

        [RelayCommand]
        private async Task StepperXAMLButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlStepperXAMLPage));
        }
    }
}
