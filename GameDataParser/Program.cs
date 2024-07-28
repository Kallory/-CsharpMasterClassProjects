
GameDataParser gameDataParser= new GameDataParser();
gameDataParser.Run();
Console.ReadLine();
public class GameDataParser {
    private Messages messages = new Messages();


    private Model model = new Model();
    public GameDataParser() {

    }

    public void Run() {
        messages.DisplayGreeting();
        messages.DisplayPromptForFileName();

        string fileName = model.InputForFileName();
        
        Console.WriteLine("Filename : " + fileName);

        // checking if JSON is valid
        if (model.IsValidJSON(fileName)) {
            List<GameDataAsJSON> gamesList = model.ReadInJSONFromFile(fileName);
            // Console.WriteLine("GamesList.Title = " +  gamesList.First().Title);
            if (!model.IsNotEmptyList(gamesList)) {
                Console.WriteLine("Empty List");
            } else {
                model.PrintGamesList();
            }
        }



        //model.HasGamesInCollection(List < GameName > Games);

        //model.Log();
    }
}
