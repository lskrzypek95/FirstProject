
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

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
            bool isPerfectNumber = true;
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)  
                    sum += i;
            }
            if (sum == value)
                isPerfectNumber = true;
            else
                isPerfectNumber = false;
            return isPerfectNumber;
        }
    }

}
