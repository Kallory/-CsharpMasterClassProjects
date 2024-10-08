﻿
var numbers = new List<int> { 9, 7, 19, 1 };
Func<int, bool> predicateIsLargerThan10 = IsLargerThan10;
Console.WriteLine("Is any number larger than 10 in the list? " + IsAny(numbers, predicateIsLargerThan10));

Func<int, bool> predicateIsEven = IsEven;
Console.WriteLine("Is any number even in the list? " + IsAny(numbers, IsEven));
Console.ReadKey();

bool IsLargerThan10(int number) {
    return number > 10;
}

bool IsEven(int number) {

    return number % 2 == 0;
}

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate) {
    foreach (int number in numbers) {
        if (predicate(number)) return true;
    }

    return false;
}