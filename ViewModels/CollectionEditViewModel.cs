using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Messages;
using MyFirstMAUIMobileApp.Models.Titles;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionEditViewModel : ObservableObject
    {

        private string _originalMovieName;

        public string Title => TitleCollectionEdit.Title;

        [ObservableProperty]
        private string movieName;

        partial void OnMovieNameChanged(string value)
        {
            if (_originalMovieName == null)
            {
                _originalMovieName = value;
            }
        }

        private async Task EditButtonClicked()
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

            var oldMovie = new MarvelMovies(_originalMovieName);
            var newMovie = new MarvelMovies(MovieName);

            WeakReferenceMessenger.Default.Send(new UpdateMovieMessage((oldMovie, newMovie)));
            await Shell.Current.GoToAsync("..");
        }
    }
}
