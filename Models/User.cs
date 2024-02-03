namespace Users;
using Artists;

public class User
{

    public string Username {get; set;}
    public string Email {get; set;}
    public string Password {get; set;}
    public DateTime dateJoined {get; set;}
    public bool isASponser {get; set;}
    public List<Artist> favorites {get; set;}

}