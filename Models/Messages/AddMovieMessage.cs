using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIMobileApp.Models.Entities;

namespace MyFirstMAUIMobileApp.Models.Messages
{
    public class AddMovieMessage : ValueChangedMessage<MarvelMovies>
    {
        public AddMovieMessage(MarvelMovies movie) : base(movie) { }
    }
}
