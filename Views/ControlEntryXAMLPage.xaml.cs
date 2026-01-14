using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.ViewModels;

namespace MyFirstMAUIMobileApp.Views;

public partial class ControlEntryXAMLPage : ContentPage
{
	public ControlEntryXAMLPage()
	{
		BindingContext = new ControlEntryXAMLViewModel();

		InitializeComponent();
	}

	private async void SubmitClicked(object sender, EventArgs e)
	{
		string entryText = EntryValue.Text;

		if (string.IsNullOrWhiteSpace(entryText))
		{
			await Shell.Current.DisplayAlert(TitleControlEntryXAML.Title, "Entry is empty. Please enter text.", "OK");
        }
		else
		{
            await Shell.Current.DisplayAlert(TitleControlEntryXAML.Title, "You entered: " + entryText, "OK");
        }
    }
}