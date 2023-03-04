namespace FirstProject
{
    internal class Menu
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("Kalkulator - wybierz 1");
            Console.WriteLine("Algorytmy - wybierz 2");
            Console.WriteLine("Działanie na plikach txt - wybierz 3");
        }
        public void ShowBaseCalculatorMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Dodawanie - wybierz 1");
            Console.WriteLine("Odejmowanie - wybierz 2");
            Console.WriteLine("Mnozenie - wybierz 3");
            Console.WriteLine("Dzielenie - wybierz 4");
            Console.WriteLine("Dodatkowe dzialania - wybierz 5");
            Console.ResetColor();
        }
        public void ShowBaseAlgorithmMenu()
        {
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("Dodatkowe Dzialania");
            Console.WriteLine("Liczba Pierwsza - wybierz 1");
            Console.WriteLine("Obliczanie silni - wybierz 2");
            Console.WriteLine("Obliczanie potęgi liczby - wybierz 3");
            Console.WriteLine("Liczba Doskonała - wybierz 4");
            Console.ResetColor();
        }
        public void ShowTxtOperationsMenu()
        {
            Console.WriteLine("Wyeksportuj tekst do pliku txt - wybierz 1");
            Console.WriteLine("Wyświetl tekst zawarty w pliku txt - wybierz 2");
        }
    }
}
