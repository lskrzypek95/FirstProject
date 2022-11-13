using FirstProject;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
BasedCalculator basedcalculator = new BasedCalculator();
Console.WriteLine("Dodawanie - wybierz 1");
Console.WriteLine("Odejmowanie - wybierz 2");
Console.WriteLine("Mnożenie - wybierz 3");
Console.WriteLine("Dzielenie - wybierz 4");
int action = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Podaj liczby");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
switch(action)
{
    case 1:
        Console.WriteLine("Dodawanie");
        Console.WriteLine(basedcalculator.Addiction(number1, number2));
        break;
    case 2:
        Console.WriteLine("Odejmowanie");
        Console.WriteLine(basedcalculator.Substraction(number1, number2));
        break;
    case 3:
        Console.WriteLine("Mnożenie");
        Console.WriteLine(basedcalculator.Multiplication(number1, number2));
        break;
    case 4:
        Console.WriteLine("Dzielenie");
        Console.WriteLine(basedcalculator.Division(number1, number2));
        break;

}
/*if (action == 1)
{
    Console.WriteLine("Dodawanie");
    int sum = basedcalculator.Addiction(x, y);
    Console.WriteLine(sum);
}
else if (action == 2)
{
    Console.WriteLine("Odejmowanie");
    int sub = basedcalculator.Substraction(x, y);
    Console.WriteLine(sub);
}
else if (action == 3)
{
    Console.WriteLine("Mnożenie");
    int multi = basedcalculator.Multiplication(x, y);
    Console.WriteLine(multi);
}
else if (action == 4)
{
    Console.WriteLine("Dzielenie");
    int div = basedcalculator.Division(x, y);
    Console.WriteLine(div);
}
*/