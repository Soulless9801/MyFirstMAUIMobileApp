using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class ControlEntriesViewModel : ObservableObject
    {

        public string Title => TitleControlEntries.Title;

        public string EntryVMButtonText => TitleControlEntries.EntryVMButtonText;

        public string EntryXAMLButtonText => TitleControlEntries.EntryXAMLButtonText;

        [RelayCommand]
        private async Task EntryVMButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlEntryVMPage));
        }

        [RelayCommand]
        private async Task EntryXAMLButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlEntryXAMLPage));
        }

        public ControlEntriesViewModel()
        {

        }
    }
}
