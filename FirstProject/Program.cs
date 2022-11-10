using FirstProject;
using System.ComponentModel.Design;

Console.WriteLine("FirstProject");


    BasedCalculator basedcalculator = new BasedCalculator();
Console.WriteLine("Kalkulator podstawowy");
Console.WriteLine("Dodawanie - wybierz 1");
Console.WriteLine("Odejmowanie - wybierz 2");
Console.WriteLine("Mnożenie - wybierz 3");
Console.WriteLine("Dzielenie - wybierz 4");
int action = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj liczby");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
if (action == 1)
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
