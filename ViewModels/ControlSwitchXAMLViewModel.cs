using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlSwitchXAMLViewModel : ObservableObject
    {
        public string Title => TitleControlSwitchXAML.Title;

        public ControlSwitchXAMLViewModel()
        {

        }

    }
}
