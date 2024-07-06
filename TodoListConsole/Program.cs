using System.Collections;

List<string> todoList = new List<string>();
todoList.Add("test");

GreetUser();
DisplayMainList();
string input = ReadInputMainList();

ProcessInputMainList(input);
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

void ProcessInputMainList(string input) {
    bool isExit = false;
    do {
        if (string.Equals(input.ToUpper(), "S")) {
            ViewList();
            DisplayMainList();
            input = ReadInputMainList();
        } else if (string.Equals(input.ToUpper(), "A")) {
            AddItemToList();
        } else if (string.Equals(input.ToUpper(), "R")) {
            RemoveItemFromList();
        } else if (string.Equals(input.ToUpper(), "E")) {
            ExitApp();
            isExit = true;
        } else {
            HandleInvalidInput();
        }
    } while (isExit == false);
}

void ViewList() {
    foreach (string item in todoList) {
        Console.WriteLine($"{item}");
    }
    Console.ReadLine();
}
void AddItemToList() {
    throw new NotImplementedException();
}

void RemoveItemFromList() {
    throw new NotImplementedException();
}

void ExitApp() {
    throw new NotImplementedException();
}

void HandleInvalidInput() {
    throw new NotImplementedException();
}


