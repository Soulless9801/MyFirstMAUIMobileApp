using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutVerticalStackViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title =  TitleLayoutVerticalStack.Title;
        public LayoutVerticalStackViewModel()
        {

        }
    }
}
