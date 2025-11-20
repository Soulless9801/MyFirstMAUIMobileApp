using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionsViewModel : ObservableObject
    {

        public string Title => TitleCollections.Title;

        public string CollectionButtonText => TitleCollections.CollectionButtonText;

        public string CollectionImagesButtonText => TitleCollections.CollectionImagesButtonText;

        public string CollectionButtonsButtonText => TitleCollections.CollectionButtonsButtonText;

        public string CollectionIconsButtonText => TitleCollections.CollectionIconsButtonText;

        [RelayCommand]
        private async Task CollectionImagesButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionImagesPage));
        }

        [RelayCommand]
        private async Task CollectionButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionPage));
        }

        [RelayCommand]
        private async Task CollectionButtonsButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionButtonsPage));
        }

        [RelayCommand]
        private async Task CollectionIconsButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionIconsPage));
        }

        public CollectionsViewModel()
        {

        }
    }
}
