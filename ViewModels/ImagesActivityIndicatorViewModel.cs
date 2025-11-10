using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;
//using Microsoft.Maui.Controls;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImagesActivityIndicatorViewModel : ObservableObject
    {

        public string Title => TitleImagesActivityIndicator.Title;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleImagesURI.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            finally
            {
                isLoading = false;
            }
        }

        public ImagesActivityIndicatorViewModel()
        {

            _ = LoadImageAsync();
        }
    }
}
