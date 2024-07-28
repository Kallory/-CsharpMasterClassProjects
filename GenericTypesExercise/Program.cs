using Coding.Exercise;
using System;

var pairOfStrings = new Pair<string>("Hi", "bye");



Console.WriteLine("First in pair is " + pairOfStrings.First);
Console.ReadLine();
Console.WriteLine("Second in pair is " + pairOfStrings.Second);
Console.ReadLine();
pairOfStrings.ResetFirst();

Console.WriteLine("First is now " + pairOfStrings.First);
Console.ReadLine();
Console.WriteLine("Press any key to exit");
Console.ReadLine();

namespace Coding.Exercise {
    public class Pair<T> {
        public T First { get; private set; }
        public T Second { get; private set; }

        public Pair(T first, T second) {
            First = first;
            Second = second;
        }

        public void ResetFirst() {
            First = default;
        }

        public void ResetSecond() {
            Second = default;
        }
    }
}
