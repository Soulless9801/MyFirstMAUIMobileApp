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
        private string verticalLayoutButtonText = TitleLayouts.VerticalLayoutButtonText;

        [ObservableProperty]
        private string horizontalLayoutButtonText = TitleLayouts.HorizontalLayoutButtonText;

        [ObservableProperty]
        private string absoluteLayoutButtonText = TitleLayouts.AbsoluteLayoutButtonText;

        [ObservableProperty]
        private string flexLayoutButtonText = TitleLayouts.FlexLayoutButtonText;

        public LayoutsViewModel()
        {

        }
    }
}
