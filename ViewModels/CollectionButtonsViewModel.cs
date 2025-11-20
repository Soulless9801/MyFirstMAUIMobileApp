using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionButtonsViewModel : ObservableObject
    {

        public string Title => TitleCollectionButtons.Title;

        public CollectionButtonsViewModel()
        {

        }
    }
}
