
GreetUser();
DisplayMainList();
string input = ReadInputMainList();


Console.ReadLine();


void GreetUser() {
    Console.WriteLine("Hello!");
    Console.WriteLine();
}

void DisplayMainList() {
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
}

string ReadInputMainList() {
    string input = Console.ReadLine();
    return input;
}

int RegisterInput