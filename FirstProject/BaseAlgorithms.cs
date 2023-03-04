
namespace FirstProject
{
    
    internal class BaseAlgorithms
    {
        public bool IsPrime(int value)
        {
            bool isPrime = true;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                    isPrime = false;
            }
            return isPrime;
        }
        public int GetFactorial(int value)
        {
            int factorial = 1;
            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public int GetPower(int value1, int value2)
        {
            int power = 1;
            for (int i = 0; i < value2; i++)
            {
                power *= value1;
            }
            return power;
        }
        public bool IsPerfectNumber(int value)
        {
            int sum = 0;
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                    sum += i;
            }
            return sum == value;
        }
        public int GetAverage(int[] value)
        {
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
            }
            return sum / value.Length;
        }

    }
}
