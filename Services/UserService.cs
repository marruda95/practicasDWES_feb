using Artists;
using Projects;
using Users;
using Microsoft.VisualBasic;


public class UserService {
InitialConfigurationService initialConfigurationService = new InitialConfigurationService();
CommonService commonService = new CommonService(); 
public bool logged = false;
int exit = 0;


public int userMenu(List<User> users){

    // Secondary Menu: User Area
     Console.ForegroundColor = ConsoleColor.Cyan;
     Console.Write("------- Welcome Back! ------\n");
     Console.Write("------    (or not)    ------\n");
     Console.ResetColor();
     Console.Write("......... 1 Members Login\n"); 
     Console.Write("......... 2 Sign Up\n");
     Console.Write("......... 3 Back to Main Menu\n");

     string optionUserMenu = Console.ReadLine();

    
     if (optionUserMenu == "1"){
        // Login 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please follow the instructions on screen:\n ");
        Console.ResetColor();

        Console.Write("......... Email:\n ");
        string email = Console.ReadLine();
        var userSelected = users.Find( e => e.Email == email);

        if (userSelected == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sorry, that user doesn't exist.\n ");
            return 1;
        } else {
            Console.Write("......... Password:\n ");
            string password = Console.ReadLine();
            if (userSelected.Password == password){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Welcome back {userSelected.Username}! \n");
                logged = true;
                Console.ResetColor();
                return 0;

            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Incorrect Password");
                Console.ResetColor(); 
                logged = false;
                return 1;
            }
        }

        commonService.splitLine();
        return 1;
    
     } else if (optionUserMenu == "2"){
        // Sign Up
        addNewMember(users);
        commonService.splitLine();
        logged = true;
        return 0;
     } else if (optionUserMenu == "3"){
        commonService.splitLine();
        return 0;
     } else {
        commonService.incorrectInput();
        return 0;
     }
}  

    public void addNewMember(List<User> users){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please fill in the following information:\n ");
        Console.ResetColor();

        Console.Write("......... Email:\n ");
        string email = Console.ReadLine();
        Console.Write("......... Password:\n ");
        string password = Console.ReadLine();
        Console.Write("......... Username: ");
        string username = Console.ReadLine();
        Console.Write("......... Would You Like To Become a Sponsor?");
        Console.Write(".............. 1) YES");
        Console.Write(".............. 2) NO");
        string is_sponsor = Console.ReadLine();
        bool sponsor = false;
        if (is_sponsor == "1"){
            sponsor = true;
        } 

        users.Add(new User{
                Email = $"{email}",
                Password = $"{password}",
                Username = $"{username}",
                isASponser = sponsor,
                dateJoined = new DateTime()
            }
        );
    }

    
    public void addToFav(List<Artist> artists, List<User> users) {
        Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("....... Would you like to add an Artist to your favorites? \n (Y / N)");
            string option = Console.ReadLine();
            Console.ResetColor();
            option.ToLower();
            if (option == "n"){
                Console.WriteLine("Well, okay, whatever.");
            } else if (option == "y"){
                if (logged == false){
                    Console.WriteLine("Sorry! You'll need to log into your account to do this.");
                    commonService.splitLine();
                    exit = userMenu(users);
                }

                Console.WriteLine("Please enter the name of the artist you'd like to add to favorites: ");
                artists.ForEach(e => 
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; 
                        Console.WriteLine($"Artist: {e.Name}");
                    }
                );

                Console.ResetColor();
                string chosenArtist = Console.ReadLine();
                var newFavArtist = artists.Find(e => e.Name == chosenArtist);
                

                // SHOW USER FAVORITES
                Console.WriteLine("Added Artist to your favorites: ");
                Console.WriteLine($" - {newFavArtist.Name} // {newFavArtist.Alias}");
                commonService.splitLine();
                

            } else {
                commonService.incorrectInput();
            }

    }
}



