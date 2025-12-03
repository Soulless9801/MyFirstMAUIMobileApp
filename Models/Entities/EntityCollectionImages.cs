namespace MyFirstMAUIMobileApp.Models.Entities;

public class GOGActor
{
    public string ActorName { get; set; }

    public string CharacterName { get; set; }

    public ImageSource ImageURL { get; set; }

    public GOGActor()
    {

    }

    public GOGActor(string actorName, string charName, ImageSource imgURL) 
    {
        ActorName = actorName;
        CharacterName = charName;
        ImageURL = imgURL;
    }

    public static List<GOGActor> GetActors() => new List<GOGActor>
    {
        new GOGActor("Chris Pratt", "Starlord", "starlord.jpg"),
        new GOGActor("Zoe Saldana", "Gamora", "gamora.jpg"),
        new GOGActor("Vin Diesel", "Groot", "groot.jpg"),
        new GOGActor("Bradley Cooper", "Rocket", "rocket.jpg"),
        new GOGActor("Karen Gillan", "Nebula", "nebula.jpg")
     };
}
