using FirstProject;
using System;
BaseCalculator basedcalculator = new BaseCalculator();
FirstNumber firstnumber = new FirstNumber();
Console.WriteLine("Dodawanie - wybierz 1");
Console.WriteLine("Odejmowanie - wybierz 2");
Console.WriteLine("Mnożenie - wybierz 3");
Console.WriteLine("Dzielenie - wybierz 4");
Console.WriteLine("Dodatkowe działania - wybierz 5");
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
        Console.WriteLine("Mnożenie");
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
        Console.WriteLine("Dodatkowe Działania");
        Console.WriteLine("Liczba Pierwsza - wybierz 1");
        int action2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbę");
        int number3 = Convert.ToInt32(Console.ReadLine());
        switch (action2)
        {
            case 1:
                Console.WriteLine("Czy liczba jest liczbą pierwszą?");
                firstnumber.PrimeNumber(number3);
                break;
        }
        break;
}