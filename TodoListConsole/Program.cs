﻿using System.Collections;

List<string> todoList = new List<string>();
todoList.Add("test");

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
        } else if (string.Equals(input.ToUpper(), "E")) {
            ExitApp();
            isExit = true;
        } else {
            HandleInvalidInput();
        }
    } while (isExit == false);
}

void ViewList() {
    Console.WriteLine();
    foreach (string item in todoList) {
        Console.WriteLine($"{item}");
    }
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
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
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
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


