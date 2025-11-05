using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImagesViewModel : ObservableObject
    {

        public string Title => TitleImages.Title;

        [RelayCommand]
        private async Task URIImagesButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }

        [RelayCommand]
        private async Task EmbeddedImagesButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityIndicatorButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesActivityIndicatorPage));
        }

        public ImagesViewModel() 
        {
            
        }
    }
}
