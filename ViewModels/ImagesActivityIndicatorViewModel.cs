using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ImagesActivityIndicatorViewModel : ObservableObject
    {

        public string Title => TitleImagesActivityIndicator.Title;

        public ImagesActivityIndicatorViewModel()
        {

        }
    }
}
