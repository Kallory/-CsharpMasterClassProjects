using System.Numerics;
using System.Runtime.InteropServices;

var playerTeamMapping = new Dictionary<string, FIFA_CODE>();
List<Player> playerList = new List<Player>();

playerTeamMapping.Add("Lionel Messi", FIFA_CODE.ARG);
playerTeamMapping.Add("Gerónimo Rulli", FIFA_CODE.ARG);
playerTeamMapping.Add("Emiliano Martínez", FIFA_CODE.ARG);
//playerTeamMapping.Add("Manuel Neuer", "GER");
//playerTeamMapping.Add("Oliver Baumann", "GER");
//playerTeamMapping.Add("David Ospina", "COL");
//playerTeamMapping.Add("Camilo Vargas", "COL");
//playerTeamMapping.Add("Álvaro Montero", "COL");
//playerTeamMapping.Add("Carlos Cuesta", "COL");
//playerTeamMapping.Add("Jhon Lucumí", "COL");

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

//CalculateAvgSalary(playerList);

List<Pet> pets = new();
pets.Add(new Pet(PetType.Dog, 10));
pets.Add(new Pet(PetType.Cat, 5));
pets.Add(new Pet(PetType.Fish, 0.9));
pets.Add(new Pet(PetType.Dog, 45));
pets.Add(new Pet(PetType.Cat, 2));
pets.Add(new Pet(PetType.Fish, 0.02));

Console.WriteLine();
Exercise.FindMaxWeights(pets);

Dictionary<string, decimal> CalculateAvgSalary(IEnumerable<Player> playerList) {
    // group players by team
    var playersPerTeam = new Dictionary<string, List<Player>>();
    decimal totalTeamSalary = 0;
    decimal teamAvgSalary = 0;
    

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

    var avgSalaryPerTeam = new Dictionary<string, decimal>();

    foreach (var team in playersPerTeam) {
        decimal counter = 0;
        foreach (var player in playersPerTeam[team.Key]) {    // could also do playersPerTeam.Value
            // Console.WriteLine($"{team.Key}: {player.Name}");
            counter++;  // could also do playersPerTeam.Value.Count
            totalTeamSalary += player.Salary;
            
        }
        teamAvgSalary = totalTeamSalary / counter;
        avgSalaryPerTeam.Add(team.Key, teamAvgSalary);
        totalTeamSalary = 0;
    }

    foreach (var team in avgSalaryPerTeam) {
        Console.WriteLine($"{team.Key} {team.Value}");
    }
    

    return avgSalaryPerTeam;
}

Console.WriteLine();
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

enum FIFA_CODE {
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

public static class Exercise {
    public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets) {
        //your code goes here
        // group by animal type
        var groupAnimalsByPetType = new Dictionary<PetType, List<Pet>>();

        foreach (var pet in pets) {
            if (!groupAnimalsByPetType.ContainsKey(pet.PetType)) {
                groupAnimalsByPetType[pet.PetType] = new List<Pet>();
            }

            groupAnimalsByPetType[pet.PetType].Add(pet);
        }

        var result = new Dictionary<PetType, double>();

        foreach (var petType in groupAnimalsByPetType) {
            double biggestWeight = petType.Value[0].Weight;
            foreach (var pet in petType.Value) {
                if (pet.Weight > biggestWeight) biggestWeight = pet.Weight;
                Console.WriteLine($"Key: {petType.Key}     Value: {pet.Weight}");
            }
            result.Add(petType.Key, biggestWeight);
            
        }

        Console.WriteLine();
        foreach (var petType in result) {
            Console.WriteLine($"Key: {petType.Key}      Value: {petType.Value}");
        }
        return result;
    }
}

public class Pet {
    public PetType PetType { get; }
    public double Weight { get; }

    public Pet(PetType petType, double weight) {
        PetType = petType;
        Weight = weight;
    }

    public override string ToString() => $"{PetType}, {Weight} kilos";
}

public enum PetType { Dog, Cat, Fish }