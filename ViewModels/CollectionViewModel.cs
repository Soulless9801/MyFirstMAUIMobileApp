using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MAUIFirstMobileApp.ViewModels;

public partial class CollectionViewModel : ObservableObject
{
    
    private List<MarvelMovies> _marvelmovies;

    public string Title => TitleCollection.Title;

    public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

    public CollectionViewModel()
    {
        _marvelmovies = MarvelMovies.GetMovies();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            MarvelMoviesCollection.Clear();
            foreach (var p in _marvelmovies)
            {
                MarvelMoviesCollection.Add(new MarvelMovies { NameofMovie = p.NameofMovie });
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
