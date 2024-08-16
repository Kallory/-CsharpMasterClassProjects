var numbers = new List<int> { 10, 12, -100, 55, 17, 22};

static string GetInput() {
    Console.WriteLine(@"Select filter:
    Even
    Odd
    Positive");

    var userInput = Console.ReadLine();
    return userInput;
}

Print(numbers);



string userInput = GetInput();
while (string.Equals(userInput, "exit") == false) {
    
    List<int> result = new NumbersFilter().FilterBy(userInput, numbers);

    Print(result);
    userInput = GetInput();
}


Console.WriteLine("Press any key to exit");
Console.ReadKey();

void Print(IEnumerable<int> numbers) {
    Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter {
    public List<int> FilterBy(string filterType, List<int> numbers) {
        switch (filterType) {
            case "Even":
                return Select(numbers, numbers => numbers % 2 == 0);
            case "Odd":
                return Select(numbers, numbers => numbers % 2 == 1);
            case "Positive":
                return Select(numbers, numbers => numbers > 1 );
            default:
                throw new NotSupportedException($"{filterType} is not a valid filter.");
        }
    }

    private List<int> Select(List<int> numbers, Func<int, bool> predicate) {
        var result = new List<int>();

        foreach (var number in numbers) {
            if (predicate(number)) {
                result.Add(number);
            }
        }

        return result;
    }

    private List<int> SelectEven(List<int> numbers) {
        List<int> result = new List<int>();
        foreach (int number in numbers) {
            if (number % 2 == 0) result.Add(number);
        }
        return result;
    }

    private List<int> SelectOdd(List<int> numbers) {
        List<int> result = new List<int>();
        foreach (int number in numbers) {
            if (number % 2 == 1) result.Add(number);
        }
        return result;
    }

    private List<int> SelectPositive(List<int> numbers) {
        List<int> result = new List<int>();
        foreach (int number in numbers) {
            if (number > 0) result.Add(number);
        }
        return result;
    }
}





