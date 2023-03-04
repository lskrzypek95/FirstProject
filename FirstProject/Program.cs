using FirstProject;
using System;
using System.Drawing;
using System.IO;

BaseCalculator basedcalculator = new BaseCalculator();
BaseAlgorithms basealgorithms = new BaseAlgorithms();
ConsoleColors colours = new ConsoleColors();
Menu menu = new Menu();
menu.ShowMainMenu();
int baseAction = Convert.ToInt32(Console.ReadLine());


switch (baseAction)
{
    case 1:
        menu.ShowBaseCalculatorMenu();
        int baseCalculation = Convert.ToInt32(Console.ReadLine());
        int number1 = 0;
        int number2 = 0;
        switch (baseCalculation)
        {
            case 1:
                colours.WriteLineWithColors("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColors("Dodawanie", ConsoleColor.DarkBlue);
                colours.WriteLineWithColors(basedcalculator.Addiction(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 2:
                colours.WriteLineWithColors("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColors("Odejmowanie", ConsoleColor.Red);
                colours.WriteLineWithColors(basedcalculator.Substraction(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 3:
                colours.WriteLineWithColors("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColors("Mnozenie", ConsoleColor.DarkBlue);
                colours.WriteLineWithColors(basedcalculator.Multiplication(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 4:
                colours.WriteLineWithColors("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColors("Dzielenie", ConsoleColor.DarkGreen);
                colours.WriteLineWithColors(basedcalculator.Division(number1, number2), ConsoleColor.DarkCyan);
                break;
        }
        break;
    case 2:
        {
            menu.ShowBaseAlgorithmMenu();
            int baseAlgorithms = Convert.ToInt32(Console.ReadLine());
            colours.WriteLineWithColors("Podaj liczbę", ConsoleColor.DarkCyan);
            int value1 = 0;
            int value2 = 0;
            switch (baseAlgorithms)
            {
                case 1:
                    colours.WriteLineWithColors("Podaj liczbę - sprawdz czy jest liczba pierwsza", ConsoleColor.Red);
                    value1 = Convert.ToInt32(Console.ReadLine());
                    if (basealgorithms.IsPrime(value1))
                        colours.WriteLineWithColors("Liczba jest liczba pierwsza", ConsoleColor.DarkBlue);
                    else
                        colours.WriteLineWithColors("Liczba nie jest liczba pierwsza", ConsoleColor.DarkBlue);
                    break;
                case 2:
                    colours.WriteLineWithColors("Obliczenie silni z liczby", ConsoleColor.Red);
                    value1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(basealgorithms.GetFactorial(value1));
                    break;
                case 3:
                    colours.WriteLineWithColors("Kalkulator potęg", ConsoleColor.Red);
                    Console.WriteLine("Podaj podstawę potęgi");
                    value1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wykładnik potęgi");
                    value2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(basealgorithms.GetPower(value1, value2));
                    break;
                case 4:
                    colours.WriteLineWithColors("Podaj liczbę - sprawdz czy jest liczba doskonala", ConsoleColor.Red);
                    value1 = Convert.ToInt32(Console.ReadLine());
                    if (basealgorithms.IsPerfectNumber(value1))
                        colours.WriteLineWithColors("Liczba jest liczba doskonala", ConsoleColor.DarkBlue);
                    else
                        colours.WriteLineWithColors("Liczba nie jest liczba doskonala", ConsoleColor.DarkBlue);
                    break;
            }
            break;
        }
    case 3:
        {
            menu.ShowTxtOperationsMenu();
            int textOperations = Convert.ToInt32(Console.ReadLine());
            switch (textOperations)
            {
                case 1:
                    {
                        string path1 = @"C:\Users\zodzy\Desktop\FirstProject\FirstProject\txt.txt";
                        string text = Console.ReadLine();
                        {
                                File.AppendAllText(path1, text);
                                Console.WriteLine("Tekst został dodany do pliku.");         
                        }
                        break;
                    }
                case 2:
                    {
                        string path2 = @"C:\Users\zodzy\Desktop\FirstProject\FirstProject\txt.txt";
                        string[] lines = File.ReadAllLines(path2);
                        Console.WriteLine("Linie z pliku:");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        break;
                    }
            }
            break;
        }
        
}