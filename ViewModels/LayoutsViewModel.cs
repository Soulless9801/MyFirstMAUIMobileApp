using MyFirstMAUIMobileApp.Models.Titles;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutsViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayouts.Title;

        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayout;

        [ObservableProperty]
        private string verticalLayout = TitleLayouts.VerticalLayout;

        [ObservableProperty]
        private string horizontalLayout = TitleLayouts.HorizontalLayout;

        [ObservableProperty]
        private string absoluteLayout = TitleLayouts.AbsoluteLayout;

        public LayoutsViewModel()
        {

        }
    }
}
