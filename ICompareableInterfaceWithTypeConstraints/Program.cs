using System.Runtime.ExceptionServices;

var numbers = new List<int> { 5, 1, 7, 2 };
numbers.Sort();

var words = new List<string> { "drum", "abercot", "cat", "batty_Roy" };
words.Sort();

var people = new List<Person> {
    new Person {Name = "John", YearOfBirth = 1980 },
    new Person {Name = "Anna", YearOfBirth = 1915 },
    new Person {Name = "Billy", YearOfBirth = 2011 }
};

people.Sort();

PrintInOrder(10, 5);

Console.WriteLine("Press any key to exit");
Console.ReadKey();


void PrintInOrder(int first, int second) {
    if (first > second) Console.WriteLine($"{second} {first}");
    else Console.WriteLine($"{first} {second}");
}


// IComparable - 2.CompareTo(1) returns 1
//             - 1.CompareTo(2) returns -1     basically ThisCurrentAttribute.CompareTo(OtherAttribute)
internal class Person : IComparable<Person> {
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public int CompareTo(Person other) {
        if (YearOfBirth < other.YearOfBirth) return 1;
        else if (YearOfBirth > other.YearOfBirth) return -1;
        else return 0;
    }
}