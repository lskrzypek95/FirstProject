
using System;

namespace FirstProject
{
    internal class ConsoleColors
    {
        public void WriteLineWithColors(string value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public void WriteLineWithColors(int value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
