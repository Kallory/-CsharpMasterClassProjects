List<string> list = new List<string> { "hola", "cya" };
list[0] = "hi";
list[1] = "bye";
list.Add("heyyyy");

Console.WriteLine(list[0]);
Console.WriteLine(list[^1]);
Console.WriteLine(list[^2]);
Console.ReadLine();