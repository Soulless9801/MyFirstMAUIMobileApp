using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutsViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayouts.Title;

        [ObservableProperty]
        private string stackLayoutButtonText = TitleLayouts.StackLayoutButtonText;

        [ObservableProperty]
        private string verticalStackLayoutButtonText = TitleLayouts.VerticalStackLayoutButtonText;

        [ObservableProperty]
        private string horizontalStackLayoutButtonText = TitleLayouts.HorizontalStackLayoutButtonText;

        [ObservableProperty]
        private string absoluteLayoutButtonText = TitleLayouts.AbsoluteLayoutButtonText;

        [ObservableProperty]
        private string flexLayoutButtonText = TitleLayouts.FlexLayoutButtonText;

        [RelayCommand]
        private async Task StackLayoutButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutStackPage));
        }

        [RelayCommand]
        private async Task VerticalStackLayoutButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutVerticalStackPage));
        }

        public LayoutsViewModel()
        {

        }
    }
}
