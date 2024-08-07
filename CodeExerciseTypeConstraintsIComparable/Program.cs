public class SortedList<T> where T: IComparable<T>
{
    public IEnumerable<T> Items { get; }

    public SortedList(IEnumerable<T> items) {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}

public class FullName : IComparable<FullName>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public int CompareTo(FullName other) {
        if (this.LastName.CompareTo(other.LastName) < 0) return -1;
        else if (this.LastName.CompareTo(other.LastName) > 0) return 1;
        else if (other.LastName.Equals(this.LastName)) {
            if (this.FirstName.CompareTo(other.FirstName) < 0) return -1;
            else return 1;
        }

        return 0;

    }

    public override string ToString() => $"{FirstName} {LastName}";

}
