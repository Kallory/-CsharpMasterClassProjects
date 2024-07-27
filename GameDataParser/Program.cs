
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


        // Validate Filename
        
        // model.FileNameExists(fileName);

        //// checking if JSON is valid
        //model.IsValidJSON(fileName);

        //model.HasGamesInCollection(List < GameName > Games);

        //model.Log();
    }
}
