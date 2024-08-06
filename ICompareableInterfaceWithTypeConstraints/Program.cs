var numbers = new List<int> { 5, 1, 7, 2 };
numbers.Sort();

var words = new List<string> { "drum", "abercot", "cat", "batty_Roy" };
words.Sort();

var people = new List<Person> {
    new Person {Name = "John", YearOfBirth = 1980 },
    new Person {Name = "Anna", YearOfBirth = 1915 },
    new Person {Name = "Billy", YearOfBirth = 2011 }
};

Console.WriteLine("Press any key to exit");
Console.ReadKey();

internal class Person : IComparable<Person> {
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public int CompareTo(Person other) {
        if (YearOfBirth < other.YearOfBirth) return 1;
        else if (YearOfBirth > other.YearOfBirth) return -1;
        else return 0;
    }
}