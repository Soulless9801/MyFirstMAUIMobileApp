using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutStackViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayoutStack.Title;

        public LayoutStackViewModel()
        {

        }
    }
}
