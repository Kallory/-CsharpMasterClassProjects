﻿using System.Text.Json;

public class Model {
    private string input;
    public List<GameDataAsJSON> Games { get; set; }
    public Model()
    {
        //this.Games = games;
    }

    public string InputForFileName() {

        bool IsHappyFileName = false;
        while (!IsHappyFileName) {
            input = Console.ReadLine();
            if (!IsNotNullOrEmpty(input)) {
                continue;
            }

            if (!FileNameExists(input)) {
                continue;
            }

            IsHappyFileName= true;
        }
        return input;
    }

    public List<GameDataAsJSON> ReadInJSONFromFile(string filename) {
        string json = File.ReadAllText(filename);

        try {
            Games =
                    JsonSerializer.Deserialize<List<GameDataAsJSON>>(json);
            foreach (var game in Games) {
                Console.WriteLine($"{game.Title}");
                Console.WriteLine($"{game.ReleaseYear}");
                Console.WriteLine($"{game.Rating}");
            }
            return Games;

        } catch (JsonException ex) {
            Console.WriteLine($"Invalid JSON file, error: {ex.Message}");
            string logs = File.ReadAllText("logs.txt");
            logs += $"[{DateTime.Now}]: Exception Message: {ex.Message}, Stack Trace: {ex.StackTrace} \n";
            File.WriteAllText("logs.txt", logs);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        return new List<GameDataAsJSON>();
    }

    public bool IsValidJSON(string fileName) {

        return true;
    }

    /// <summary>
    ///  The following functions are helper functions to validate the filename, checking if it exists, if it's null, or if it's empty.
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    private bool FileNameExists(string fileName) {
        if (!File.Exists(fileName)) {
            Console.WriteLine("Filename not found, type a valid filename: ");
            return false;
        } 
        return true;
    }

    private bool IsNotNullOrEmpty(string input) {
        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Error: Input is null or empty, type a valid filename: ");
            return false;
        }
        return true;
    }

    internal bool IsNotEmptyList(List<GameDataAsJSON> gamesList) {
        if (gamesList.First().Title is null) {
            return false;
        }

        return true;
    }
}

public class GameDataAsJSON {
    //"Title": "Stardew Valley",
    //"ReleaseYear": 2016,
    //"Rating": 4.9

    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }

    public GameDataAsJSON(string title, int releaseYear, double rating) {
        Title = title;
        ReleaseYear = releaseYear;
        Rating = rating;
    }
}