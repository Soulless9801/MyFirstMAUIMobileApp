using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class LayoutFlexViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayoutFlex.Title;

        public LayoutFlexViewModel()
        {

        }
    }
}
