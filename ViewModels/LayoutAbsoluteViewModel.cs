using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutAbsoluteViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayoutAbsolute.Title;

        public LayoutAbsoluteViewModel()
        {

        }
    }
}
