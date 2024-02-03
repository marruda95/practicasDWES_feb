namespace Artists;
using Projects;

public class Artist
{

    public int ArtistID {get; set;}
    public string Name {get; set;}
    public string Alias {get; set;}
    public double ArtistRating {get; set;}
    public DateTime dateJoined {get; set;}
    public bool isSponsered {get; set;}
    public List<Project> project {get; set;}
}