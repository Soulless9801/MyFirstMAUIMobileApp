using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImagesEmbeddedViewModel : ObservableObject
    {

        public string Title => TitleImagesEmbedded.Title;

        public ImagesEmbeddedViewModel()
        {

        }
    }
}
