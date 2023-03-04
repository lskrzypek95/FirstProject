using System;
namespace FirstProject
{
    internal class ConsoleColors
    {
        public void WriteLineWithColor(string value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public void WriteLineWithColor(int value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
