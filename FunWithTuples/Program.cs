Tuple<int, int, int, int> myTuple = new Tuple<int, int, int, int>(456, 2, 3, 4);

Console.WriteLine(myTuple.Item1);

Console.ReadLine();


// This is how to do it without telling the class to have generics
public static class TupleSwapExercise {
    public static Tuple<T2, T1> SwapTupleItems<T1, T2>(Tuple<T1, T2> tuple) {


        return new Tuple<T2, T1>(tuple.Item2, tuple.Item1);
    }
}