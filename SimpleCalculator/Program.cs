Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");

int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string selectedOption = Console.ReadLine();
if (string.Equals(selectedOption.ToUpper(), "A")) {
    int result = firstNumber + secondNumber;
    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
    Console.ReadLine();
} else if (string.Equals(selectedOption.ToUpper(), "S")) {
    int result = firstNumber - secondNumber;
    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
    Console.ReadLine();
} else if (string.Equals(selectedOption.ToUpper(), "M")) {
    int result = firstNumber * secondNumber;
    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
    Console.ReadLine();
} else {
    Console.WriteLine("Invalid Option");
    Console.ReadLine();
}

