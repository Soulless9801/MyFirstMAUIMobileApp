using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIMobileApp.Models.Entities;
using MyFirstMAUIMobileApp.Models.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMAUIMobileApp.ViewModels;

public partial class CollectionImagesViewModel : ObservableObject
{

    private List<GOGActor> _gogactors;

    public string Title => TitleCollectionImages.Title;

    public ObservableCollection<GOGActor> GOGActorsCollection { get; } = new();

    public CollectionImagesViewModel()
    {
        _gogactors = GOGActor.GetActors();
        LoadActors();
    }

    private void LoadActors()
    {
        try
        {
            GOGActorsCollection.Clear();
            foreach (var p in _gogactors)
            {
                GOGActorsCollection.Add(new GOGActor { ActorName = p.ActorName, CharacterName = p.CharacterName, ImageURL = p.ImageURL });
            }
        }   
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
