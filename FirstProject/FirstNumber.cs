
namespace FirstProject
{
    internal class FirstNumber
    { 
        public void PrimeNumber(int number3)
        {
            bool firstnumber = true;
            for (int i = 2; i < number3; i++)
            {
                if (number3 % i == 0)
                    firstnumber = false;
            }
            if (firstnumber == true)
                Console.WriteLine("Liczba jest liczbą pierwszą");
            else
                Console.WriteLine("Liczba nie jest liczbą pierwszą");
        }
    }

}
