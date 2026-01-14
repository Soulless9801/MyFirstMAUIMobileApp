using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    [QueryProperty(nameof(EntryText), "entryText")]
    public partial class ControlEntryResultViewModel : ObservableObject
    {

        public string Title => TitleControlEntryResult.Title;

        [ObservableProperty]
        private string entryText;
    }
}
