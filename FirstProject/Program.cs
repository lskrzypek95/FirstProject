using FirstProject;
using System;
BaseCalculator basedcalculator = new BaseCalculator();
PrimeNumber primeNumber = new PrimeNumber();
Console.WriteLine("Dodawanie - wybierz 1");
Console.WriteLine("Odejmowanie - wybierz 2");
Console.WriteLine("Mnozenie - wybierz 3");
Console.WriteLine("Dzielenie - wybierz 4");
Console.WriteLine("Dodatkowe dzialania - wybierz 5");
int action = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 0;

switch (action)
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
        Console.WriteLine("Dodatkowe Dzialania");
        Console.WriteLine("Liczba Pierwsza - wybierz 1");
        int baseAction = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbę");
        int value1 = Convert.ToInt32(Console.ReadLine());
        switch (baseAction)
        {
            case 1:
                Console.WriteLine("Czy liczba jest liczba pierwsza?");
                if (primeNumber.isPrime(value1))
                Console.WriteLine("Liczba jest liczba pierwsza");
                else
                    Console.WriteLine("Liczba nie jest liczba pierwsza");
                break;
        }
        break;
}