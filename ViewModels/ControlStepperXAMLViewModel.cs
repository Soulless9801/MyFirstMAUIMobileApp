using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlStepperXAMLViewModel : ObservableObject
    {
        public string Title => TitleControlStepperXAML.Title;

        public ControlStepperXAMLViewModel()
        {

        }

    }
}
