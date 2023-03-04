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
                colours.WriteLineWithColor("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColor("Dodawanie", ConsoleColor.DarkBlue);
                colours.WriteLineWithColor(basedcalculator.Addiction(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 2:
                colours.WriteLineWithColor("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColor("Odejmowanie", ConsoleColor.Red);
                colours.WriteLineWithColor(basedcalculator.Substraction(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 3:
                colours.WriteLineWithColor("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColor("Mnozenie", ConsoleColor.DarkBlue);
                colours.WriteLineWithColor(basedcalculator.Multiplication(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 4:
                colours.WriteLineWithColor("Podaj liczby", ConsoleColor.Green);
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineWithColor("Dzielenie", ConsoleColor.DarkGreen);
                colours.WriteLineWithColor(basedcalculator.Division(number1, number2), ConsoleColor.DarkCyan);
                break;
            case 5:
                Console.WriteLine("Działania w tablicy");
                Console.WriteLine("Podaj ilość liczb w tablicy");
                int arrayLenght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj zawartość tablicy");
                int[] array = new int [arrayLenght];
                for (int i =0; i < array.Length; i++)
                {
                    array [i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Średnia liczb wynosi:");
                Console.WriteLine(basealgorithms.GetAverage(array));
                Console.WriteLine("Maksymalna wartość w tabeli:");
                Console.WriteLine(array.Max());
                Console.WriteLine("Minimalna wartość w tabeli:");
                Console.WriteLine(array.Min());
                break;
        }
        break;
    case 2:
        {
            menu.ShowBaseAlgorithmMenu();
            int baseAlgorithms = Convert.ToInt32(Console.ReadLine());
            colours.WriteLineWithColor("Podaj liczbę", ConsoleColor.DarkCyan);
            int value1 = 0;
            int value2 = 0;
            switch (baseAlgorithms)
            {
                case 1:
                    colours.WriteLineWithColor("Podaj liczbę - sprawdz czy jest liczba pierwsza", ConsoleColor.Red);
                    value1 = Convert.ToInt32(Console.ReadLine());
                    if (basealgorithms.IsPrime(value1))
                        colours.WriteLineWithColor("Liczba jest liczba pierwsza", ConsoleColor.DarkBlue);
                    else
                        colours.WriteLineWithColor("Liczba nie jest liczba pierwsza", ConsoleColor.DarkBlue);
                    break;
                case 2:
                    colours.WriteLineWithColor("Obliczenie silni z liczby", ConsoleColor.Red);
                    value1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(basealgorithms.GetFactorial(value1));
                    break;
                case 3:
                    colours.WriteLineWithColor("Kalkulator potęg", ConsoleColor.Red);
                    Console.WriteLine("Podaj podstawę potęgi");
                    value1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wykładnik potęgi");
                    value2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(basealgorithms.GetPower(value1, value2));
                    break;
                case 4:
                    colours.WriteLineWithColor("Podaj liczbę - sprawdz czy jest liczba doskonala", ConsoleColor.Red);
                    value1 = Convert.ToInt32(Console.ReadLine());
                    if (basealgorithms.IsPerfectNumber(value1))
                        colours.WriteLineWithColor("Liczba jest liczba doskonala", ConsoleColor.DarkBlue);
                    else
                        colours.WriteLineWithColor("Liczba nie jest liczba doskonala", ConsoleColor.DarkBlue);
                    break;
            }
            break;
        }
    case 3:
        {
            menu.ShowTxtOperationsMenu();
            int textOperations = Convert.ToInt32(Console.ReadLine());
            const string path = @"C:\Users\zodzy\Desktop\FirstProject\FirstProject\txt.txt";
            switch (textOperations)
            {
                case 1:
                    {
                        string text = Console.ReadLine();
                        {
                                File.AppendAllText(path, text);
                                Console.WriteLine("Tekst został dodany do pliku.");         
                        }
                        break;
                    }
                case 2:
                    {
                        string[] lines = File.ReadAllLines(path);
                        Console.WriteLine("Linie z pliku:");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj numer wiersza do wyświetlenia");
                        int lineNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Linie z pliku:");
                        int row = 1;
                        foreach (string line in File.ReadLines(path))
                        {
                            if (row == lineNumber)
                            {
                                Console.WriteLine(line);
                            }
                            row++;  
                        }

                        break;
                    }
            }
            break;
        }
        
}