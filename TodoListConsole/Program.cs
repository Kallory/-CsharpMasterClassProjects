using System.Collections;

List<string> todoList = new List<string>();
// todoList.Add("test");

GreetUser();
DisplayMainList();
string inputMainList = ReadInputMainList();

ProcessInputMainList(inputMainList);
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
    Console.WriteLine();
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
            DisplayMainList();
            input = ReadInputMainList();
        } else if (string.Equals(input.ToUpper(), "R")) {
            RemoveItemFromList();
            DisplayMainList();
            input = ReadInputMainList();
        } else if (string.Equals(input.ToUpper(), "E")) {
            ExitApp();
            isExit = true;
        } else {
            HandleInvalidInput();
        }
    } while (isExit == false);
}

void ViewList() {
    if (todoList.Count() > 0) {
        Console.WriteLine();
        foreach (string item in todoList) {
            Console.WriteLine($"{todoList.IndexOf(item) + 1}) {item}");
        }
        PressEnterToContinue();
    } else {
        Console.WriteLine("Empty list!");
        PressEnterToContinue();
        Console.WriteLine();
    }
}

void ViewListForRemoveItem() {
    if (todoList.Count() > 0) {
        Console.WriteLine();
        foreach (string item in todoList) {
            Console.WriteLine($"{todoList.IndexOf(item) + 1}) {item}");
        }
    } else {
        Console.WriteLine("Empty list!");
        PressEnterToContinue();
        Console.WriteLine();
    }
}

void AddItemToList() {    
    Console.WriteLine("Type Item to add to list: ");
    string inputAddItem = Console.ReadLine();

    while (inputAddItem.Length < 1) {
        Console.WriteLine("Bad input");
        inputAddItem = Console.ReadLine();
    }

    todoList.Add(inputAddItem);
    Console.WriteLine($"{inputAddItem} added");
    PressEnterToContinue();
}

void RemoveItemFromList() {
    ViewListForRemoveItem();
    if (todoList.Count() > 0) {
        Console.WriteLine("Type index of the item you'd like to remove and press enter: ");
        var inputRemoveItem = Console.ReadLine();
        bool isValidNumber = int.TryParse(inputRemoveItem, out int number);
        bool isValidBounds = CheckIndexBounds(inputRemoveItem);

        if (isValidNumber && isValidBounds) {
            string itemToBeRemoved = todoList[int.Parse(inputRemoveItem) - 1];
            todoList.RemoveAt(int.Parse(inputRemoveItem) - 1);
            Console.WriteLine($"{itemToBeRemoved} removed");
        } else if (!isValidNumber) {
            Console.WriteLine("Please enter a number");
        } else if (!isValidBounds) {
            Console.WriteLine("Please enter a number within the bounds of the list");
        }
    }
}

bool CheckIndexBounds(string inputRemoveItem) {
    return int.Parse(inputRemoveItem) - 1 < todoList.Count() && int.Parse(inputRemoveItem) > 0;
}

void ExitApp() {
    throw new NotImplementedException();
}

void HandleInvalidInput() {
    throw new NotImplementedException();
}

static void PressEnterToContinue() {
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}