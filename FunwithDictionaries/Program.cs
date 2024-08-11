var playerTeamMapping = new Dictionary<string, string>();
List<Player> playerList = new List<Player>();

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


Player LionelMessi = new Player("Lionel Messi", "Captain", "ARG", 10000);
Player GerónimoRulli = new Player("Gerónimo Rulli", "GK", "ARG", 9000);
Player EmilianoMartínez = new Player("Emiliano Martínez", "GK", "ARG", 8000);
Player ManuelNeuer = new Player("Manuel Neuer", "GK", "GER", 7000);
Player OliverBaumann = new Player("Oliver Baumann", "GK", "GER", 9000);
Player DavidOspina = new Player("David Ospina", "GK", "COL", 10000);
Player CamiloVargas = new Player("Camilo Vargas", "GK", "COL", 5000);
Player ÁlvaroMontero = new Player("Álvaro Montero", "GK", "COL", 8000);
Player CarlosCuesta = new Player("Carlos Cuesta", "DF", "COL", 7000);
Player JhonLucumí = new Player("Jhon Lucumí", "DF", "COL", 9000);

playerList.Add(LionelMessi);
playerList.Add(GerónimoRulli);
playerList.Add(EmilianoMartínez);
playerList.Add(ManuelNeuer);
playerList.Add(OliverBaumann);
playerList.Add(DavidOspina);
playerList.Add(CamiloVargas);
playerList.Add(ÁlvaroMontero);
playerList.Add(CarlosCuesta);
playerList.Add(JhonLucumí);

CalculateAvgSalary(playerList);

Dictionary<string, decimal> CalculateAvgSalary(IEnumerable<Player> playerList) {
    // group players by team
    var playersPerTeam = new Dictionary<string, List<Player>>();

    // iterate through the collection of employees and add each of them to the list belonging to specific team
    foreach (var player in playerList) {

        // check if the team exists in the dictionary, if it doesn't, create a new list of Players and add a key value pair of TeamName and 
        // said list to the dictionary
        if (!playersPerTeam.ContainsKey(player.TeamName)) {
            playersPerTeam[player.TeamName] = new List<Player>();
        }

        // playersPerTeam[player.TeamName] should return list of players on a specific team, so we add the player the list associated with the
        // key, which in this case is a team name
        playersPerTeam[player.TeamName].Add(player);
    }

    return null;
}

Console.WriteLine();
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

enum FIFA_CODES {
    ARG,
    GER,
    COL
};




public class Player {
    public string Name { get; private set; }
    public string Position { get; private set; }
    public string TeamName { get; private set; }
    public decimal Salary { get; private set; }

    public Player(string name, string position, string teamName, decimal salary) {
        Name = name;
        Position = position; TeamName = teamName;
        Salary = salary;
    }
}