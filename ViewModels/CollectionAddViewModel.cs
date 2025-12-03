using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Messages;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionAddViewModel : ObservableObject
    {
        public string Title => TitleCollectionAdd.Title;

        [ObservableProperty]
        private string movieName = string.Empty;

        [RelayCommand]
        private async Task AddButtonClicked()
        {
            
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                await Shell.Current.DisplayAlert(
                    Title, 
                    Msgs.NotEmpty, 
                    "OK"
                );
                return;
            }

            var movie = new MarvelMovies { NameofMovie = MovieName };

            WeakReferenceMessenger.Default.Send(new AddMovieMessage(movie));

            await Shell.Current.GoToAsync("..");
        }
    }
}
