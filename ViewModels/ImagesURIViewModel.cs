using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImagesURIViewModel : ObservableObject
    {

        public string Title => TitleImagesURI.Title;

        public ImagesURIViewModel()
        {

        }
    }
}
