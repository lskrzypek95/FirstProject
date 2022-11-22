﻿
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
        public int Factorial (int value)
        {
            int factorial = 1;
            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

}
