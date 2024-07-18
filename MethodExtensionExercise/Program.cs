using Coding.Exercise;
using System;

var list = new List<int> { 1, 5, 10, 8, 12, 4, 5, 6 };
var result = list.TakeEverySecond();
foreach (int item in result) {
    Console.WriteLine(item);
}
Console.ReadLine();

namespace Coding.Exercise {
    public static class ListExtension {
        public static List<int> TakeEverySecond(this List<int> myList) {
            List<int> result = new List<int>();
            
            for (int i = 0; i < myList.Count; i++) {
                if (i % 2 == 0) {
                    result.Add(myList[i]);
                }
            }

            return result;
        }
    }
}
