using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleMain.Title;

        [ObservableProperty]
        private string layoutsButtonText = TitleMain.LayoutsButtonText;

        [ObservableProperty]
        private string imagesButtonText = TitleMain.ImagesButtonText;

        [ObservableProperty]
        private string collectionsButtonText = TitleMain.CollectionsButtonText;

        [ObservableProperty]
        private string controlsButtonText = TitleMain.ControlsButtonText;

        [ObservableProperty]
        private string sQLiteButtonText = TitleMain.SQLiteButtonText;

        [RelayCommand]
        private async Task LayoutsButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        public MainViewModel()
        {

        }

    }
}
