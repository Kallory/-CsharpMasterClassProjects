var numbers = new List<int> { 10, 12, -100, 55, 17, 22};

Print(numbers);


Console.WriteLine("Press any key to exit");
Console.ReadKey();

void Print(IEnumerable<int> numbers) {
    Console.WriteLine(string.Join(", ", numbers));
}