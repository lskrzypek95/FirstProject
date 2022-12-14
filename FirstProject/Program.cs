using FirstProject;
using System;
BaseCalculator basedcalculator = new BaseCalculator();
BaseAlgorithms basealgorithms = new BaseAlgorithms();
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
        Console.WriteLine(basedcalculator.Addiction(number1, number2));
        break;
    case 2:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Odejmowanie");
        Console.WriteLine(basedcalculator.Substraction(number1, number2));
        break;
    case 3:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mnozenie");
        Console.WriteLine(basedcalculator.Multiplication(number1, number2));
        break;
    case 4:
        Console.WriteLine("Podaj liczby");
        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dzielenie");
        Console.WriteLine(basedcalculator.Division(number1, number2));
        break;
    case 5:
        menu.ShowBaseAlgorithmMenu();
        int baseAlgorithms = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbę");
        int value1 = 0;
        int value2 = 0;
        switch (baseAlgorithms)
        {
            case 1:
                Console.WriteLine("Podaj liczbę - sprawdz czy jest liczba pierwsza");
                value1 = Convert.ToInt32(Console.ReadLine());
                if (basealgorithms.IsPrime(value1))
                    Console.WriteLine("Liczba jest liczba pierwsza");
                else
                    Console.WriteLine("Liczba nie jest liczba pierwsza");
                break;
            case 2:
                Console.WriteLine("Obliczenie silni z liczby");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(basealgorithms.GetFactorial(value1));
                break;
            case 3:
                Console.WriteLine("Kalkulator potęg");
                Console.WriteLine("Podaj podstawę potęgi");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Poda wykładnik potęgi");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(basealgorithms.GetPower(value1, value2));
                break;
            case 4:
                Console.WriteLine("Podaj liczbę - sprawdz czy jest liczba doskonala");
                value1 = Convert.ToInt32(Console.ReadLine());
                if (basealgorithms.IsPerfectNumber(value1))
                    Console.WriteLine("Liczba jest liczba doskonala");
                else
                    Console.WriteLine("Liczba nie jest liczba doskonala");
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
}