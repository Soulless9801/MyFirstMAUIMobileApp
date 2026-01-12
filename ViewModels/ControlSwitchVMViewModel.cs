using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlSwitchVMViewModel : ObservableObject
    {
        public string Title => TitleControlSwitchVM.Title;

        [ObservableProperty]
        private bool isToggled;

        [ObservableProperty]
        private Color textColor;

        partial void OnIsToggledChanged(bool value)
        {
            TextColor = value
                ? Color.FromRgb(0, 0, 255)
                : Color.FromRgb(255, 0, 0);
        }

        public ControlSwitchVMViewModel()
        {

            IsToggled = true;
            TextColor = Color.FromRgb(0, 0, 255);
        }

    }
}
