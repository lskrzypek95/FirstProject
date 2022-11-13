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
        public int Addiction(int number1, int number2) => (number1 + number2);
        public int Substraction(int number1, int number2) => (number1 - number2);
        public int Multiplication(int number1, int number2) => (number1 * number2);
        public int Division(int number1, int number2) => (number1 / number2);
    }
}
