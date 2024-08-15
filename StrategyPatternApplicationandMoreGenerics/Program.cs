var numbers = new List<int> { 10, 12, -100, 55, 17, 22};

Console.WriteLine(@"Select filter:
Even
Odd
Positive");

var userInput = Console.ReadLine();

List<int> result;


Print(numbers);
Print(result);


Console.WriteLine("Press any key to exit");
Console.ReadKey();

void Print(IEnumerable<int> numbers) {
    Console.WriteLine(string.Join(", ", numbers));
}

public class NumbersFilter {
    public List<int> FilterBy(string filterType, List<int> numbers) {
        switch (filterType) {
            case "Even":
                return SelectEven(numbers);
            case "Odd":
                return SelectOdd(numbers);
            case "Positive":
                return SelectPositive(numbers);
            default:
                throw new NotSupportedException($"{filterType} is not a valid filter.");
        }
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





