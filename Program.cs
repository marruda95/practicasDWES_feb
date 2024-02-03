using Spectre.Console;
using Artists;
using Users;
using Projects;


// INITIAL VARIABLES
int exit = 0;
bool logged = false; 
var config = new InitialConfigurationService();
var userService = new UserService();
var commonService = new CommonService();
var artistService = new ArtistService(); 
var userList = new List<User>();
var artistList = new List<Artist>(); 
var users = config.defaultUser(userList);
var artists = config.defaultArtists(artistList);


while (exit == 0){
    mainMenu();
}

void mainMenu(){
        // USER IS NOT LOGGED
        if (userService.logged == false){
            Console.Write("Welcome to MyArtist\n");
            Console.Write("Please choose and option to continue\n"); 
            Console.Write("......... 1 Our Artists\n"); 
            Console.Write("......... 2 Search by Artist\n"); 
            Console.Write("......... 3 User Login\n"); 
            Console.Write("......... 4 Exit App\n");
        } 

        // IF USER IS LOGGED 
        if(userService.logged == true){
            Console.Write("Welcome to MyArtist");
            Console.Write("Please choose and option to continue\n"); 
            Console.Write("......... 1 Our Artists\n"); 
            Console.Write("......... 2 Search by Artist\n"); 
            Console.Write("......... 3 My Favorite Artists\n"); 
            Console.Write("......... 4 Exit App\n");

        }

        string chosenOption = Console.ReadLine();
    
        if (userService.logged == true){
            if (chosenOption == "1"){
                artistService.showArtists(artists);
                commonService.splitLine();
                userService.addToFav(artists, users);
            } else if (chosenOption == "2") {
                artistService.searchByArtist(artists);
                commonService.splitLine();
            } else if (chosenOption == "3") {
                    // Show Favorite Artists
            } else if (chosenOption == "4") {
                exit = commonService.exitingApp();
            } else {
                exit = commonService.incorrectInput(); 
            }
        }

        if (userService.logged == false){
            if (chosenOption == "1"){
                artistService.showArtists(artists);
                commonService.splitLine();
                userService.addToFav(artists, users);
            } else if (chosenOption == "2") {
                artistService.searchByArtist(artists);
            } else if (chosenOption == "3") {
                exit = userService.userMenu(users);
            } else if (chosenOption == "4") {
                exit = commonService.exitingApp();
            } else {
                exit = commonService.incorrectInput(); 
            } 
        }
        
    }
