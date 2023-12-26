﻿#region Task1
/*
// Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək

Console.WriteLine("Please enter a sentence: ");
string sentence1, sentence2 = "";
sentence1 = Console.ReadLine();
int j = 0;
for (int i = 0; i < sentence1.Length; i++) {
    if (sentence1[i] != ' ')
        sentence2 += sentence1[i];
}
Console.WriteLine($"Newly created sentence:\n{sentence2}");
*/
#endregion

#region Task2
/*
// Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram

int size;
do {
    Console.WriteLine("Please enter the size of array: ");
    size = int.Parse(Console.ReadLine());
} while(size <= 0);

int[] numbers = new int[size];

Console.WriteLine("Please enter the number `n` to search for");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < size; i++) {
    Console.Write("Please enter a number for array: ");
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}
bool nFound = false;
for (int i = 0; i < size; i++) {
    if (numbers[i] == n) {
        Console.WriteLine($"`{n}` is located on the index {i}");
        nFound = true;
        break;
    }
}

if (!nFound) Console.WriteLine($"{n} is not there!");
*/
#endregion

#region Task3
/*
// Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

int size;
int count = 0;
do {
    Console.Write("Please enter the size of array: ");
    size = int.Parse(Console.ReadLine());
} while (size <= 0);

string[] strings = new string[size];

for (int i = 0; i < size; i++) {
    Console.Write($"Please enter the {i + 1}. string for the array to include: ");
    string str = Console.ReadLine();
    strings[i] = str;
}

Console.Write("Please enter the letter to search for: ");
char letter = char.Parse(Console.ReadLine());

for (int i = 0; i < size; i++) {
    for (int j = 0; j < strings[i].Length; j++) {
        if (strings[i][j] == letter) count++;
    }
}
Console.WriteLine($"There are {count} times `{letter}` there.");
*/
#endregion

#region Task4
/*
// Verilmiş yazının her iki terefindeki boşluqlar silinmiş bir string düzəldən proqram

Console.WriteLine("Please enter a sentence: ");
string sentence1 = Console.ReadLine();
string sentence2 = "";

int leftIndex = 0;
while (sentence1[leftIndex] == ' ') {
    leftIndex++;
}
int rightIndex = 0;
while (sentence1[sentence1.Length - rightIndex - 1] == ' ') {
    rightIndex++;
}

for (int i = leftIndex; i < sentence1.Length - rightIndex; i++) {
    sentence2 += sentence1[i];
}
Console.WriteLine($"Trimmed sentence: {sentence2}");
*/
#endregion

#region Task5
/*
// Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.

char[] symbolArray = new char[4] { '+', '*', '-', '/' };

Console.Write("Please enter the first number: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Please enter the second number: ");
double number2 = double.Parse(Console.ReadLine());

char operation;
bool isThere = false;
do {
    Console.Write("Please choose an operation between (+, -, *, /): ");
    operation = char.Parse(Console.ReadLine());

    for (int i = 0; i < symbolArray.Length; i++) {
        if (operation == symbolArray[i]) {
            isThere = true;
            break;
        }
    }
} while (!isThere);

switch (operation) {
    case '+':
        Console.WriteLine(number1 + number2);
        break;
    case '-':
        Console.WriteLine(number1 - number2);
        break;
    case '/':
        if (number2 == 0) {
            Console.WriteLine("You cannot divide by zero!");
            break;
        }
        Console.WriteLine(number1 / number2);
        break;
    case '*':
        Console.WriteLine(number1 * number2);
        break;
    default:
        break;
}
*/
#endregion