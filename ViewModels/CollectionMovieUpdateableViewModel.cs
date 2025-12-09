using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Messages;
using MyFirstMAUIMobileApp.Models.Titles;
using MyFirstMAUIMobileApp.Views;
using System.Collections.ObjectModel;

namespace MyFirstMAUIMobileApp.ViewModels
{
    public partial class CollectionMovieUpdateableViewModel : ObservableObject
    {

        public string Title => TitleCollectionMovieUpdateable.Title;

        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private ObservableCollection<MarvelMovies> movieCollection = new();

        [RelayCommand]
        private async Task Refresh()
        {
            if (IsBusy) return;
            IsBusy = true;

            await Task.Run(() =>
            {
                MovieCollection.Clear();
                foreach (var movie in MarvelMovies.GetMovies())
                {
                    MovieCollection.Add(movie);
                }
            });
        }

        [RelayCommand]
        private async Task AddMovie()
        {
            WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);

            await Shell.Current.GoToAsync(nameof(CollectionAddPage));

            WeakReferenceMessenger.Default.Register<AddMovieMessage>(this, (r, m) =>
            {
                MovieCollection.Add(m.Value);
                WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            });
        }

        [RelayCommand]
        private async Task EditMovie(MarvelMovies movie)
        {
            string encodedName = Uri.EscapeDataString(movie.NameofMovie);
            await Shell.Current.GoToAsync($"{nameof(CollectionEditPage)}?movieName={encodedName}");
        }

        [RelayCommand]
        private void DeleteMovie(MarvelMovies movie)
        {
            MovieCollection.Remove(movie);
        }

        public CollectionMovieUpdateableViewModel()
        {
            WeakReferenceMessenger.Default.Register<UpdateMovieMessage>(this, (r, m) =>
            {
                var oldTitle = m.OldMovie.NameofMovie;
                var idx = MovieCollection.ToList().FindIndex(mv => mv.NameofMovie == oldTitle);

                if (idx >= 0)
                {
                    MovieCollection[idx] = m.NewMovie;
                }
            });

            RefreshCommand.Execute(null);
        }
    }
}