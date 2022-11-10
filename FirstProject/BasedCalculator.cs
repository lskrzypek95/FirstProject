using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class BasedCalculator
    {

        public int Addiction(int x, int y)
        {
            return x + y;
        }
        public int Substraction(int x, int y)
        {
            return x - y;
        }
        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y; 
        }

    }
}
