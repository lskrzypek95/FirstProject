using FirstProject;
using System;
BaseCalculator basedCalculator = new BaseCalculator();
BaseAlgorithms baseAlgorithms = new BaseAlgorithms();
Menu menu = new Menu();
menu.ShowBaseCalculatorMenu();
int baseAction = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 0;

switch (baseAction)
{
    case 1:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dodawanie");
        Console.WriteLine(basedCalculator.Addiction(number1, number2));
        break;
    case 2:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Odejmowanie");
        Console.WriteLine(basedCalculator.Substraction(number1, number2));
        break;
    case 3:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mnozenie");
        Console.WriteLine(basedCalculator.Multiplication(number1, number2));
        break;
    case 4:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dzielenie");
        Console.WriteLine(basedCalculator.Division(number1, number2));
        break;
    case 5:
        menu.ShowBaseAlgorithmMenu();
        int baseAlgorithmsAction = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbę");
        int value1 = 0;
        int value2 = 0;
        switch (baseAlgorithmsAction)
        {
            case 1:
                Console.WriteLine("Podaj liczbę - sprawdz czy jest liczba pierwsza");
                value1 = Convert.ToInt32(Console.ReadLine());
                if (baseAlgorithms.IsPrime(value1))
                    Console.WriteLine("Liczba jest liczba pierwsza");
                else
                    Console.WriteLine("Liczba nie jest liczba pierwsza");
                break;
            case 2:
                Console.WriteLine("Obliczenie silni z liczby");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(baseAlgorithms.GetFactorial(value1));
                break;
            case 3:
                Console.WriteLine("Kalkulator potęg");
                Console.WriteLine("Podaj podstawę potęgi");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Poda wykładnik potęgi");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(baseAlgorithms.GetPower(value1, value2));
                break;
            case 4:
                Console.WriteLine("Podaj liczbę - sprawdz czy jest liczba doskonala");
                value1 = Convert.ToInt32(Console.ReadLine());
                if (baseAlgorithms.IsPerfectNumber(value1))
                    Console.WriteLine("Liczba jest liczba doskonala");
                else
                    Console.WriteLine("Liczba nie jest liczba doskonala");
                break;
        }
        break;
}