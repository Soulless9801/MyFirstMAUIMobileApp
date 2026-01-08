using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlSliderXAMLViewModel : ObservableObject
    {
        public string Title => TitleControlSliderXAML.Title;

        public ControlSliderXAMLViewModel()
        {

        }

    }
}
