
namespace FirstProject
{
    internal class PrimeNumber
    { 
        public bool isPrime(int value1)
        {
            bool primenumber = true;
            for (int i = 2; i < value1; i++)
            {
                if (value1 % i == 0)
                    primenumber = false;
            }
            return primenumber;
            
        }
    }

}
