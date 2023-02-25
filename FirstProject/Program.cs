using FirstProject;
using System;
using System.Drawing;
using System.IO;

string path = @"C:\Users\zodzy\Desktop\FirstProject\FirstProject\txt.txt";
string text = "Witaj w moim kalkulatorze!";
{
    try
    {
        File.AppendAllText(path, text);
        Console.WriteLine("Tekst został dodany do pliku.");
    }
    catch (IOException)
    { }  
}
try
{
    string[] lines = File.ReadAllLines(path);
    Console.WriteLine("Linie z pliku:");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException)
{}


BaseCalculator basedcalculator = new BaseCalculator();
BaseAlgorithms basealgorithms = new BaseAlgorithms();
ConsoleColors colours = new ConsoleColors();
Menu menu = new Menu();
menu.ShowBaseCalculatorMenu();
int baseAction = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 0;


switch (baseAction)
{
    case 1:
        colours.WriteLineChooseColorText("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineChooseColorText("Dodawanie", ConsoleColor.DarkBlue);
        colours.WriteLineChooseColorNumbers(basedcalculator.Addiction(number1, number2), ConsoleColor.DarkCyan);
        break;
    case 2:
        colours.WriteLineChooseColorText("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineChooseColorText("Odejmowanie", ConsoleColor.Red);
        colours.WriteLineChooseColorNumbers(basedcalculator.Substraction(number1, number2), ConsoleColor.DarkCyan);
        break;
    case 3:
        colours.WriteLineChooseColorText("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineChooseColorText("Mnozenie", ConsoleColor.DarkBlue);
        colours.WriteLineChooseColorNumbers(basedcalculator.Multiplication(number1, number2), ConsoleColor.DarkCyan);
        break;
    case 4:
        colours.WriteLineChooseColorText("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineChooseColorText("Dzielenie",ConsoleColor.DarkGreen);
        colours.WriteLineChooseColorNumbers(basedcalculator.Division(number1, number2), ConsoleColor.DarkCyan);
        break;
    case 5:
        menu.ShowBaseAlgorithmMenu();
        int baseAlgorithms = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineChooseColorText("Podaj liczbę",ConsoleColor.DarkCyan);
        int value1 = 0;
        int value2 = 0;
        switch (baseAlgorithms)
        {
            case 1:
                colours.WriteLineChooseColorText("Podaj liczbę - sprawdz czy jest liczba pierwsza", ConsoleColor.Red);
                value1 = Convert.ToInt32(Console.ReadLine());
                if (basealgorithms.IsPrime(value1))
                    colours.WriteLineChooseColorText("Liczba jest liczba pierwsza", ConsoleColor.DarkBlue);
                else
                    colours.WriteLineChooseColorText("Liczba nie jest liczba pierwsza", ConsoleColor.DarkBlue);
                break;
            case 2:
                colours.WriteLineChooseColorText("Obliczenie silni z liczby", ConsoleColor.Red);
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(basealgorithms.GetFactorial(value1));
                break;
            case 3:
                colours.WriteLineChooseColorText("Kalkulator potęg", ConsoleColor.Red);
                Console.WriteLine("Podaj podstawę potęgi");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj wykładnik potęgi");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(basealgorithms.GetPower(value1, value2));
                break;
            case 4:
                colours.WriteLineChooseColorText("Podaj liczbę - sprawdz czy jest liczba doskonala", ConsoleColor.Red);
                value1 = Convert.ToInt32(Console.ReadLine());
                if (basealgorithms.IsPerfectNumber(value1))
                    colours.WriteLineChooseColorText("Liczba jest liczba doskonala", ConsoleColor.DarkBlue);
                else
                    colours.WriteLineChooseColorText("Liczba nie jest liczba doskonala", ConsoleColor.DarkBlue);
                break;
        }
        break;
}