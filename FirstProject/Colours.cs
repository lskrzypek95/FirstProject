
using System;

namespace FirstProject
{
    internal class ConsoleColors
    {
        public void WriteLineChooseColorText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void WriteLineChooseColorNumbers(int text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
