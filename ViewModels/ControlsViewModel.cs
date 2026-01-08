using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlsViewModel : ObservableObject
    {
        public string Title => TitleControls.Title;

        public string ControlSliderButtonText => TitleControls.ControlSliderButtonText;

        public string ControlStepperButtonText => TitleControls.ControlStepperButtonText;

        public string ControlSwitchButtonText => TitleControls.ControlSwitchButtonText;

        [RelayCommand]
        private async Task ControlSliderButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSlidersPage));
        }

        [RelayCommand]
        private async Task ControlStepperButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlStepperPage));
        }

        [RelayCommand]
        private async Task ControlSwitchButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSwitchPage));
        }

        public ControlsViewModel()
        {

        }   

    }
}
