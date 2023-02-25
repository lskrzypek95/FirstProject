using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class txt
    {
        public void toTxt()
        {
            string path = @"C:\Users\zodzy\Desktop\FirstProject\FirstProject\txt.txt";
            string text = "Witaj w moim kalkulatorze!";
            try
            {
                File.AppendAllText(path, text);
                Console.WriteLine("Tekst został dodany do pliku.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Błąd zapisu do pliku: " + e.Message);
            }
        }
        public void fromTxt()
        {
            {
                string path = @"C:\Users\zodzy\Desktop\FirstProject\FirstProject\txt.txt";
                try
                {
                    string[] lines = File.ReadAllLines(path); 
                    Console.WriteLine("Linie z pliku:");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Błąd odczytu pliku: " + e.Message);
                }
            }
        }
    }
}




   