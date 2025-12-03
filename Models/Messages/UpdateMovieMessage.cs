using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIMobileApp.Models.Entities;

namespace MyFirstMAUIMobileApp.Models.Messages
{
    public class UpdateMovieMessage : ValueChangedMessage<(MarvelMovies oldMovie, MarvelMovies newMovie)>
    {
        public UpdateMovieMessage((MarvelMovies oldMovie, MarvelMovies newMovie) movies) : base(movies) { }

        public MarvelMovies OldMovie => Value.oldMovie;

        public MarvelMovies NewMovie => Value.newMovie;

    }
}
