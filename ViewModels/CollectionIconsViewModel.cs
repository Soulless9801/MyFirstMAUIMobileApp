using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionIconsViewModel : ObservableObject
    {

        public string Title => TitleCollectionIcons.Title;

        public CollectionIconsViewModel()
        {

        }
    }
}
