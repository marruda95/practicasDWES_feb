using Microsoft.VisualBasic;
using Artists;
using Projects;
public class ArtistService { 
InitialConfigurationService initialConfigurationService = new InitialConfigurationService();
CommonService commonService = new CommonService();
public void showArtists(List<Artist> artists) {
     artists.ForEach( e => {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine($"Name: {e.Name}");
            Console.WriteLine($"Alias: {e.Alias}");
            Console.ResetColor(); 
            Console.WriteLine($"Joined: {e.dateJoined}");
            if (e.ArtistRating > 5.00) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Artist Rating: {e.ArtistRating}");
            } else {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Artist Rating: {e.ArtistRating}");
            }

             if (e.isSponsered == true) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"**Sponsored Artist**");
            } else {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"**Artist Not Sponsored**");
            }

            e.project.ForEach(e => {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (e.isAvailable == true) {
                    Console.WriteLine($".......... **** AVAILABLE NOW ****");
                } 
                Console.WriteLine($".......... Project: {e.ProjectName}");
                Console.ResetColor();
                Console.WriteLine($".......... Description: {e.ProjectDescription}");
                Console.WriteLine($".......... Medium: {e.ProjectMedium}");
                Console.WriteLine($".......... Date Created: {e.dateCreated}");

                if (e.ProjectRating > 5.00) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($".......... Rating: {e.ProjectRating}\n");
                } else {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine($".......... Rating: {e.ProjectRating}\n");
                }
                 Console.ResetColor();
                
            });
            Console.ResetColor();
        
        } );

}

public void searchByArtist(List<Artist> artists)
        {
            Console.WriteLine("Introduce the artist you're looking for: ");
            string artistName = Console.ReadLine();

            var filteredArtists = new List<Artist>();
            artists.ForEach(e =>
            {
                if (e.Name.Contains(artistName))
                {
                    filteredArtists.Add(e);
                }
            });

            if(filteredArtists.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Artist not found\n");
                Console.ResetColor();
            }
            else
            {
                filteredArtists.ForEach(e =>
                {
                    Console.WriteLine($" - By: {e.Name}");
                }); 
            }
        }

}