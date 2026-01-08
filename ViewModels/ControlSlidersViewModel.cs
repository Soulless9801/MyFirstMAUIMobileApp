using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlSlidersViewModel : ObservableObject
    {
        public string Title => TitleControlSliders.Title;

        public string SliderVMButtonText => TitleControlSliders.SliderVMButtonText;

        public string SliderXAMLButtonText => TitleControlSliders.SliderXAMLButtonText;

        [RelayCommand]
        private async Task SliderVMButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSliderVMPage));
        }
        
        [RelayCommand]
        private async Task SliderXAMLButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSliderXAMLPage));
        }
    }
}
