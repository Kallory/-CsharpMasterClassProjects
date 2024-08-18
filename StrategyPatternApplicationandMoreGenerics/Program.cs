var numbers = new List<int> { 10, 12, -100, 55, 17, 22};
var filteringStrategySelector = new FilteringStrategySelector();
var utilityFunctions = new UtilityFunctions();


Print(numbers);



string userInput = utilityFunctions.GetInput();
while (string.Equals(userInput, "exit") == false) {
    var filteringStrategy = new FilteringStrategySelector().Select(userInput);
    List<int> result = new Filter().FilterBy(filteringStrategy, numbers);

    Print(result);
    userInput = utilityFunctions.GetInput();
}


Console.WriteLine("Press any key to exit");
Console.ReadKey();

void Print(IEnumerable<int> numbers) {
    Console.WriteLine(string.Join(", ", numbers));
}

public class FilteringStrategySelector {

    private readonly Dictionary<string, Func<int, bool>> _filteringStrategies = new Dictionary<string, Func<int, bool>> {
        ["Even"] = numbers => numbers % 2 == 0,
        ["Odd"] = numbers => numbers % 2 == 1,
        ["Positive"] = numbers => numbers > 1,

    };

    public IEnumerable<string> FilteringStrategyNames => _filteringStrategies.Keys;

    public Func<int, bool> Select(string filterType) {
        if (!_filteringStrategies.ContainsKey(filterType)) {
            throw new NotSupportedException($"{filterType} is not a valid filter.");
        }

        return _filteringStrategies[filterType];

        //switch (filterType) {
        //    case "Even":
        //        return numbers => numbers % 2 == 0;
        //    case "Odd":
        //        return numbers => numbers % 2 == 1;
        //    case "Positive":
        //        return numbers => numbers > 1;
        //    default:
        //        throw new NotSupportedException($"{filterType} is not a valid filter.");
        //}
    }
}

public class Filter {
    public List<T> FilterBy<T>(Func<T, bool> predicate, List<T> numbers) {

        var result = new List<T>();

        foreach (var number in numbers) {
            if (predicate(number)) {
                result.Add(number);
            }
        }

        return result;

    }
}

public class UtilityFunctions {
    FilteringStrategySelector _filteringStrategySelector;

    public UtilityFunctions() {
        this._filteringStrategySelector = new FilteringStrategySelector();
    }


    public string GetInput() {
        Console.WriteLine("Select filter:");
        Console.WriteLine(string.Join(Environment.NewLine, _filteringStrategySelector.FilteringStrategyNames));

        var userInput = Console.ReadLine();
        return userInput;
    }
}





