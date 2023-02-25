using FirstProject;
using System;
using System.Drawing;
using System.IO;
txt Txt = new txt();
Txt.toTxt();
Txt.fromTxt();

BaseCalculator basedcalculator = new BaseCalculator();
BaseAlgorithms basealgorithms = new BaseAlgorithms();
Colours colours = new Colours();
Menu menu = new Menu();
menu.ShowBaseCalculatorMenu();
int baseAction = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 0;


switch (baseAction)
{
    case 1:
        colours.WriteLineGreen("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineRed("Dodawanie");
        colours.WriteLineCyan(basedcalculator.Addiction(number1, number2));
        break;
    case 2:
        colours.WriteLineGreen("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineRed("Odejmowanie");
        colours.WriteLineCyan(basedcalculator.Substraction(number1, number2));
        break;
    case 3:
        colours.WriteLineGreen("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineRed("Mnozenie");
        colours.WriteLineCyan(basedcalculator.Multiplication(number1, number2));
        break;
    case 4:
        colours.WriteLineGreen("Podaj liczby", ConsoleColor.Green);
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineRed("Dzielenie");
        colours.WriteLineCyan(basedcalculator.Division(number1, number2));
        break;
    case 5:
        menu.ShowBaseAlgorithmMenu();
        int baseAlgorithms = Convert.ToInt32(Console.ReadLine());
        colours.WriteLineRed("Podaj liczbę");
        int value1 = 0;
        int value2 = 0;
        switch (baseAlgorithms)
        {
            case 1:
                colours.WriteLineRed("Podaj liczbę - sprawdz czy jest liczba pierwsza");
                value1 = Convert.ToInt32(Console.ReadLine());
                if (basealgorithms.IsPrime(value1))
                    colours.WriteLineBlue("Liczba jest liczba pierwsza");
                else
                    colours.WriteLineBlue("Liczba nie jest liczba pierwsza");
                break;
            case 2:
                colours.WriteLineRed("Obliczenie silni z liczby");
                value1 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineCyan(basealgorithms.GetFactorial(value1));
                break;
            case 3:
                colours.WriteLineRed("Kalkulator potęg");
                Console.WriteLine("Podaj podstawę potęgi");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Poda wykładnik potęgi");
                value2 = Convert.ToInt32(Console.ReadLine());
                colours.WriteLineCyan(basealgorithms.GetPower(value1, value2));
                break;
            case 4:
                colours.WriteLineRed("Podaj liczbę - sprawdz czy jest liczba doskonala");
                value1 = Convert.ToInt32(Console.ReadLine());
                if (basealgorithms.IsPerfectNumber(value1))
                    colours.WriteLineBlue("Liczba jest liczba doskonala");
                else
                    colours.WriteLineBlue("Liczba nie jest liczba doskonala");
                break;
        }
        break;
}