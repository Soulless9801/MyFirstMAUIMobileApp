using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlSliderVMViewModel : ObservableObject
    {

        public string Title => TitleControlSliderVM.Title;

        [ObservableProperty]
        private double sliderValue;

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.5;
        }

        public ControlSliderVMViewModel()
        {
            SliderValue = 1;
        }
    }
}
