using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlEntryVMViewModel : ObservableObject
    {

        public string Title => TitleControlEntryVM.Title;

        [ObservableProperty]
        private string entryText;

        [RelayCommand]
        private async Task EntryClicked()
        {
            await Shell.Current.GoToAsync($"{nameof(ControlEntryResultPage)}?entryText={EntryText}");
        }

        public ControlEntryVMViewModel()
        {

        }
    }
}
