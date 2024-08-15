var numbers = new List<int> { 10, 12, -100, 55, 17, 22};

Console.WriteLine(@"Select filter:
Even
Odd");

var userInput = Console.ReadLine();

List<int> result;
switch(userInput) {
    case "Even":
        result = SelectEven(numbers); break;
    case "Odd":
        result = SelectOdd(numbers); break;
    default:
        throw new NotSupportedException($"{userInput} is not a valid filter.");
}

Print(numbers);


Console.WriteLine("Press any key to exit");
Console.ReadKey();

void Print(IEnumerable<int> numbers) {
    Console.WriteLine(string.Join(", ", numbers));
}