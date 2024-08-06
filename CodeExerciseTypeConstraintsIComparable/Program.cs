public class SortedList<T> //your code goes here
{
    public IEnumerable<T> Items { get; }

    public SortedList(IEnumerable<T> items) {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}

public class FullName // your code goes here
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public override string ToString() => $"{FirstName} {LastName}";

    //your code hoes here
}
