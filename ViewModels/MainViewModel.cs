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
        private string layouts = TitleMain.Layouts;

        [ObservableProperty]
        private string images= TitleMain.Images;

        [ObservableProperty]
        private string collections = TitleMain.Collections;

        [ObservableProperty]
        private string controls = TitleMain.Controls;

        [ObservableProperty]
        private string sQLite = TitleMain.SQLite;

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        public MainViewModel()
        {

        }

    }
}
