var playerTeamMapping = new Dictionary<string, string>();

playerTeamMapping.Add("Lionel Messi", "ARG");
playerTeamMapping.Add("Gerónimo Rulli", "ARG");
playerTeamMapping.Add("Emiliano Martínez", "ARG");
playerTeamMapping.Add("Manuel Neuer", "GER");
playerTeamMapping.Add("Oliver Baumann", "GER");
playerTeamMapping.Add("David Ospina", "COL");
playerTeamMapping.Add("Camilo Vargas", "COL");
playerTeamMapping.Add("Álvaro Montero", "COL");
playerTeamMapping.Add("Carlos Cuesta", "COL");
playerTeamMapping.Add("Jhon Lucumí", "COL");

foreach (var playerTeamPair in playerTeamMapping) {
    Console.WriteLine($"Player: {playerTeamPair.Key}       Country: {playerTeamPair.Value}");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

enum FIFA_CODES {
    ARG,
    GER,
    COL
};
