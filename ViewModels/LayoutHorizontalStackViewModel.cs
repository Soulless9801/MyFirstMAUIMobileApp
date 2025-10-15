using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutHorizontalStackViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayoutHorizontalStack.Title;

        public LayoutHorizontalStackViewModel()
        {

        }
    }
}
