using Artists;
using Projects;
using Users; 
public class InitialConfigurationService{
    

// INITIAL ARTISTS
public List<Artist> defaultArtists(List<Artist> artists) {
    artists.Add(new Artist{
        ArtistID = 1,
        Name = "Joshua Strange",
        Alias = "JeeStrange",
        ArtistRating = 4.56,
        dateJoined = new DateTime(),
        isSponsered = false,
        project = new List<Project>{
            new Project{
                ProjectID = 1,
                ProjectName = "CanaryIslands",
                ProjectDescription = "A pretty picture of the Canary Islands",
                ProjectMedium = "Photography",
                ProjectRating = 3,
                dateCreated = new DateTime(),
                isAvailable = false
            }
        }
    });

   artists.Add(new Artist{
        ArtistID = 2,
        Name = "Harry Pott",
        Alias = "TheBoyWhoDidntLive",
        ArtistRating = 5.02,
        dateJoined = new DateTime(),
        isSponsered = true,
        project = new List<Project>{
            new Project{
                ProjectID = 1,
                ProjectName = "VoldeWHO",
                ProjectDescription = "We Don't Like Voldy",
                ProjectMedium = "Acrylic",
                ProjectRating = 5,
                dateCreated = new DateTime(),
                isAvailable = true
            },
             new Project{
                ProjectID = 2,
                ProjectName = "AreYouSirius?",
                ProjectDescription = "My Uncle Was a Wolf",
                ProjectMedium = "Acrylic",
                ProjectRating = 7,
                dateCreated = new DateTime(),
                isAvailable = true
            }
        }
    });

     artists.Add(new Artist{
        ArtistID = 3,
        Name = "Christina Smith",
        Alias = "ChrissyTH",
        ArtistRating = 7.67,
        dateJoined = new DateTime(),
        isSponsered = false,
        project = new List<Project>{
            new Project{
                ProjectID = 1,
                ProjectName = "Pretty Sky",
                ProjectDescription = "What I like to look at in the morning",
                ProjectMedium = "Digital",
                ProjectRating = 4,
                dateCreated = new DateTime(),
                isAvailable = true
            },
             new Project{
                ProjectID = 2,
                ProjectName = "Another Sky",
                ProjectDescription = "The Sky but at Night",
                ProjectMedium = "Digital",
                ProjectRating = 7,
                dateCreated = new DateTime(),
                isAvailable = false
            },
            new Project{
                ProjectID = 3,
                ProjectName = "Skyrim Vibes",
                ProjectDescription = "Self Portrait if I were in a character in Skyrim",
                ProjectMedium = "Digital",
                ProjectRating = 10,
                dateCreated = new DateTime(),
                isAvailable = true
            }
        }
    });
    return artists;
}

// INITIAL USER
public List<User> defaultUser(List<User> users) {
    users.Add(new User{
        Username = "MaRruda",
        Email = "mariaemail@gmail.com",
        Password = "1234",
        dateJoined = new DateTime(),
        isASponser = true
    });
    return users;
    }
}